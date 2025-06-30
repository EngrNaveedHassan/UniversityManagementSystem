using BLL.Interface;
using Domain.Entities;

namespace BLL.Services
{
    internal class BookService : IService<Book>
    {
        private readonly IService<Book> _bookRepository;

        public BookService(IService<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task Create(Book entity)
        {
            try
            {
                if (entity == null) 
                    throw new ArgumentNullException(nameof(entity));

                await _bookRepository.Create(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task Delete(Book entity)
        {
            try
            {
                if(entity == null)
                    throw new ArgumentNullException(nameof(entity));
                await _bookRepository.Delete(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<Book?> GetById(string id)
        {
            try
            {
                if(id == null)
                    throw new ArgumentNullException(nameof(id));

                var book = await _bookRepository.GetById(id);
                if (book == null)
                    throw new ArgumentException("Not Found");
                return book;
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<List<Book>> Read()
        {
            try
            {
                return await _bookRepository.Read();
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public void Update(Book entity)
        {
            try
            {
                if(entity == null)
                    throw new ArgumentNullException(nameof(entity));
                _bookRepository.Update(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }
    }
}
