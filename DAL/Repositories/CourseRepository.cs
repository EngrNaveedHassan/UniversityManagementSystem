using DAL.Data;
using DAL.Interface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Course entity)
        {
            await _context.Courses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Course entity)
        {
            _context.Courses.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Course?> GetById(string id)
        {
            return await _context.Courses.FirstOrDefaultAsync(c => c.CourseCode == id);
        }

        public async Task<List<Course>> Read()
        {
            return await _context.Courses.ToListAsync();
        }

        public async void Update(Course entity)
        {
            _context.Courses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
