using DAL.Data;
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

        public async Task<bool> Create(Book entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Book entity)
        {
            _context.Books.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Book?> GetById(string id)
        {
            return await _context.Books.FirstOrDefaultAsync(b => b.ISBN == id);
        }

        public async Task<List<Book>> Read(List<Book> entities)
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<bool> Update(Book entity)
        {
            _context.Books.Update(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
