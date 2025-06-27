using DAL.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class SubjectRepository : IRepository<Subject>
    {
        private readonly AppDbContext _context;

        public SubjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Subject entity)
        {
            await _context.Subjects.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Subject entity)
        {
            _context.Subjects.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Subject?> GetById(string id)
        {
            return await _context.Subjects.FirstOrDefaultAsync(s => s.SubjectCode == id);
        }

        public async Task<List<Subject>> Read(List<Subject> entities)
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task<bool> Update(Subject entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
