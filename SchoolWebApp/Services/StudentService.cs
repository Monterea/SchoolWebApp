using Microsoft.EntityFrameworkCore;
using SchoolWebApp.Controllers;
using SchoolWebApp.Data;
using SchoolWebApp.Models;
using SchoolWebApp.ViewModels;

namespace SchoolWebApp.Services {
    public class StudentService {
        private ApplicationDbContext _dbContext;
        public StudentService(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }
        internal async Task<IEnumerable<Student>> GetAllAsync() {
            return await _dbContext.Students.ToListAsync();
        }
        internal async Task <Student> GetByIdAsync(int id) {
            return await _dbContext.Students.FirstOrDefaultAsync(st => st.Id == id);
        }
        internal async Task CreateAsync(Student newStudent) {
            await _dbContext.Students.AddAsync(newStudent);
            await _dbContext.SaveChangesAsync();
        }
        internal async Task UpdateAsync(int id, Student updatedStudent) {
            _dbContext.Students.Update(updatedStudent);
            await _dbContext.SaveChangesAsync();
        }
        internal async Task DeleteAsync(int id) {
            var studentToDelete = await _dbContext.Students.FirstOrDefaultAsync(st => st.Id == id); 
            _dbContext.Students.Remove(studentToDelete);
            await _dbContext.SaveChangesAsync();
        }
    }
}