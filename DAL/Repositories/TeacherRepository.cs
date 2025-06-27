using DAL.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly AppDbContext _context;

        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Teacher entity)
        {
            await _context.Teachers.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Teacher entity)
        {
            _context.Teachers.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Teacher?> GetById(string id)
        {
            return await _context.Teachers.FirstOrDefaultAsync(t => t.Id == id);
        }

        public Task<List<Teacher>> Read(List<Teacher> entities)
        {
            return _context.Teachers.ToListAsync();
        }

        public async Task<bool> Update(Teacher entity)
        {
            _context.Teachers.Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
