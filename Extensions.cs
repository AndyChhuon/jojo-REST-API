using JobApplicants.Models;
using JobApplicants.Models.DTO;

namespace JobApplicants
{
    public static class Extensions
    {
        public static ApplicantDTO toDTO(this Applicant Applicant)
        {
            return new ApplicantDTO { Id = Applicant.Id, Name = Applicant.Name, CreatedDate = Applicant.CreatedDate };
        }
    }
}
