using BLL.Interface;
using Domain.Entities;
namespace BLL.Services
{
    public class TeacherService : IService<Teacher>
    {
        private readonly IService<Teacher> _teacherRepository;

        public TeacherService(IService<Teacher> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task Create(Teacher entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                await _teacherRepository.Create(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task Delete(Teacher entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                await _teacherRepository.Delete(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<Teacher?> GetById(string id)
        {
            try
            {
                if(id == null)
                    throw new ArgumentNullException("id");

                var teacher =  await _teacherRepository.GetById(id);
                if (teacher == null)
                    throw new ArgumentException("Not Found");
                return teacher;
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<List<Teacher>> Read()
        {
            try
            {
                return await _teacherRepository.Read();
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public void Update(Teacher entity)
        {
            throw new NotImplementedException();
        }
    }
}
