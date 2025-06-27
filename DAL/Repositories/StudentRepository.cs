using DAL.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext context) 
        {
            _context = context;
        }
        public async Task<bool> Create(Student entity)
        {
            await _context.Students.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Student entity)
        {
            _context.Students.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Student?> GetById(string id)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Student>> Read(List<Student> entities)
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<bool> Update(Student entity)
        {
            _context.Students.Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
