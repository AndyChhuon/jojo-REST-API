using JobApplicants.Models;
using JobApplicants.Models.DTO;
using JobApplicants.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace JobApplicants.Controllers
{
    //Define route to controller
    //Can use Route("api/[controller]") to automatically set route to JobApplicantsApi
    [Route("api/JobApplicantsAPI")] 
    [ApiController]
    public class JobApplicantsApiController : ControllerBase
    {

        private readonly IInMemItemsRepository repository;

        //Constructor
        public JobApplicantsApiController(IInMemItemsRepository repository)
        {
            this.repository = repository;
        }

        //Identify get endpoint (Get /api/JobApplicantsAPI/)
        [HttpGet]
        public IEnumerable<ApplicantDTO> GetApplicants() {
            var applicants = repository.GetApplicants().Select(Applicant => Applicant.toDTO());
            return applicants;
        }

        // Get /api/JobApplicantsAPI/{id}
        [HttpGet("{id}")]
        public ActionResult<ApplicantDTO> GetApplicant(Guid id)
        {
            var item = repository.GetApplicant(id);

            if(item is null)
            {
                return NotFound();
            }

            return item.toDTO();
        }

        // POST /api/JobApplicantsAPI/
        [HttpPost]
        public ActionResult<ApplicantDTO> AddApplicant(AddApplicantDTO applicantDTO)
        {
            Applicant applicant = new() { Id = Guid.NewGuid(), Name= applicantDTO.Name, CreatedDate = DateTimeOffset.UtcNow};
            repository.AddApplicant(applicant);

            return CreatedAtAction(nameof(GetApplicant), new { id = applicant.Id }, applicant.toDTO());
        }

        // PUT /api/JobApplicantsAPI/{id}
        [HttpPut("{id}")]
        public ActionResult<UpdateApplicantDTO> UpdateApplicant(Guid id, UpdateApplicantDTO applicantDTO)
        {
            var existingApplicant = repository.GetApplicant(id);
            
            if(existingApplicant is null)
            {
                return NotFound();
            }

            Applicant updatedApplicant = existingApplicant with
            {
                Name = applicantDTO.Name
            };

            repository.UpdateApplicant(updatedApplicant);

            //Convention for PUT (204)
            return NoContent();
        }

        // DELETE /api/JobApplicantsAPI/{id}
        [HttpDelete("{id}")]
        public ActionResult<UpdateApplicantDTO> RemoveApplicant(Guid id)
        {
            var existingApplicant = repository.GetApplicant(id);

            if (existingApplicant is null)
            {
                return NotFound();
            }


            repository.RemoveApplicant(id);

            //Convention for Delete (204)
            return NoContent();
        }
    }
}
