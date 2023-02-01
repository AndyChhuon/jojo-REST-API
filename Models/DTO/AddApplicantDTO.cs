using System.ComponentModel.DataAnnotations;

namespace JobApplicants.Models.DTO
{
    public class AddApplicantDTO
    { 
        [Required]
        public String Name { get; init; }

    }
}
