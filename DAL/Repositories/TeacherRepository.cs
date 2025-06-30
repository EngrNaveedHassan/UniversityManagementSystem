using DAL.Data;
using DAL.Interface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TeacherRepository : IRepository<Teacher>
    {
        private readonly AppDbContext _context;

        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Teacher entity)
        {
            await _context.SaveChangesAsync();
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Teacher entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Teacher?> GetById(string id)
        {
            return await _context.Teachers.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<Teacher>> Read()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async void Update(Teacher entity)
        {
            _context.Teachers.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
