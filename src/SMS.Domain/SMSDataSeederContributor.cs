using SMS.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SMS
{
    public class SMSDataSeederContributor
    : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Student, Guid> _studentRepository;

        public SMSDataSeederContributor(IRepository<Student, Guid> bookRepository)
        {
            _studentRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _studentRepository.GetCountAsync() > 0)
            {
                return;
            }

            await _studentRepository.InsertAsync(
                new Student
                {
                    FName = "Rahul",
                    LName = "Kumar",
                    Email = "rahul@gmail.com",
                    Phone = "1234567890",
                    Enrollment = "1234567890"

                   
                },
                autoSave: true
            );

            await _studentRepository.InsertAsync(
                new Student
                {
                    FName = "Raj",
                    LName = "Kumar",
                    Email = "raj@gmail.com",
                    Phone = "1234567890",
                    Enrollment = "1234567890"
                },
                autoSave: true
            );
        }
    }
}
