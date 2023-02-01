using System.ComponentModel.DataAnnotations;

namespace JobApplicants.Models.DTO
{
    public class UpdateApplicantDTO
    {
        [Required]
        public String Name { get; init; }
    }
}
