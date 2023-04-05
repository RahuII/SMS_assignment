using AutoMapper;
using SMS.Students;

namespace SMS;

public class SMSApplicationAutoMapperProfile : Profile
{
    public SMSApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
