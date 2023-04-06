using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SMS.Students;

public class Student : AuditedAggregateRoot<Guid>
{
    public string FName { get; set; }

    public string LName { get; set; }

    [Unique]
    public string Email { get; set; }

    public string Phone { get; set; }
    public string Enrollment { get; set; }
}
