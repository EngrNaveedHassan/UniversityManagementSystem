using DAL.Data;
using DAL.Interface;
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
        public async Task Create(Student entity)
        {
            await _context.Students.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Student entity)
        {
            _context.Students.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Student?> GetById(string id)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Student>> Read()
        {
            return await _context.Students.ToListAsync();
        }

        public async void Update(Student entity)
        {
            _context.Students.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
