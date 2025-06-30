using BLL.Interface;
using Domain.Entities;

namespace BLL.Services
{
    internal class CourseService : IService<Course>
    {
        public readonly IService<Course> _courseRepository;

        public CourseService(IService<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task Create(Course entity)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity);

                await _courseRepository.Create(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task Delete(Course entity)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity);

                await _courseRepository.Delete(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<Course?> GetById(string id)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(id);

                var course = await _courseRepository.GetById(id);
                if (course == null)
                    throw new ArgumentException("Not Found");
                return course;
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<List<Course>> Read()
        {
            try
            {
                return await _courseRepository.Read();

            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public void Update(Course entity)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(entity);

                _courseRepository.Update(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }
    }
}
