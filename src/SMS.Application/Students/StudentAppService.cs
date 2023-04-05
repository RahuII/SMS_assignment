using Microsoft.AspNetCore.Authorization;
using SMS.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SMS.Students;

[Authorize(SMSPermissions.Students.Default)]
public class StudentAppService : CrudAppService<
        Student, //The Book entity
        StudentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDto>, //Used to create/update a book
    IStudentAppService //implement the IBookAppService
{
    public StudentAppService(IRepository<Student, Guid> repository)
        : base(repository)
    {
        GetPolicyName = SMSPermissions.Students.Default;
        GetListPolicyName = SMSPermissions.Students.Default;
        CreatePolicyName = SMSPermissions.Students.Create;
        UpdatePolicyName = SMSPermissions.Students.Edit;
        DeletePolicyName = SMSPermissions.Students.Delete;
    }
}

