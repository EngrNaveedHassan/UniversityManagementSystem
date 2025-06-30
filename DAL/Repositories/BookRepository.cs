using DAL.Data;
using DAL.Interface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Book entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Book entity)
        {
            _context.Books.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Book?> GetById(string id)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.ISBN == id);
        }

        public async Task<List<Book>> Read()
        {
            return await _context.Books.ToListAsync();
        }

        public async void Update(Book entity)
        {
            _context.Books.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
