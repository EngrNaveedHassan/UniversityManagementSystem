﻿using BLL.Interface;
using DAL.Interface;
using Domain.Entities;

namespace BLL.Services
{
    public class StudentService : IService<Student>
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task Create(Student entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                await _studentRepository.Create(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task Delete(Student entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                await _studentRepository.Delete(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<Student?> GetById(string id)
        {
            try
            {
                if (id == null || id == "")
                    throw new ArgumentNullException(nameof(id));

                var student = await _studentRepository.GetById(id);

                if (student == null)
                    throw new ArgumentException("Not Found.");
                return student;
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public async Task<List<Student>> Read()
        {
            try
            {
                return await _studentRepository.Read();
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }

        public void Update(Student entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));

                _studentRepository.Update(entity);
            }
            catch (Exception exp)
            {
                Console.WriteLine("EXCEPTION: " + exp);
                throw;
            }
        }
    }
}
