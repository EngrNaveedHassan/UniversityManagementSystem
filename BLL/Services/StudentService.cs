using DAL.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class StudentService : IService<Student>
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<bool> Create(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var result = await _studentRepository.Create(entity);
            if(result)
                return true;
            return false;
        }

        public async Task<bool> Delete(Student entity)
        {
            if(entity == null)
                throw new ArgumentNullException(nameof(entity));

            var result = await _studentRepository.Delete(entity);
            if( result )
                return true;
            return false;
        }

        public async Task<Student?> GetById(string id)
        {
            if(id == null || id == "")
                throw new ArgumentNullException(nameof(id));

            return await _studentRepository.GetById(id);
        }

        public Task<List<Student>> Read(List<Student> entities)
        {
            if(entities == null)
                throw new ArgumentNullException(nameof(entities));

            return _studentRepository.Read(entities);
        }

        public Task<bool> Update(Student entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            return _studentRepository.Update(entity);
        }
    }
}
