using JobApplicants.Models;

namespace JobApplicants.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        //Initialize list
        private readonly List<Applicant> applicants = new()
        {
            new Applicant { Id = Guid.NewGuid(), Name = "Joe", CreatedDate = DateTimeOffset.UtcNow },
            new Applicant { Id = Guid.NewGuid(), Name = "Jack", CreatedDate = DateTimeOffset.UtcNow },
            new Applicant { Id = Guid.NewGuid(), Name = "John", CreatedDate = DateTimeOffset.UtcNow }


        };

        public IEnumerable<Applicant> GetApplicants()
        {
            return applicants;
        }

        public Applicant GetApplicant(Guid id)
        {
            //Note: singleordefault throws error if more than one as opposed to firstordefault
            return applicants.Where(applicant => applicant.Id == id).SingleOrDefault();
        }

        public void AddApplicant(Applicant applicant)
        {
            applicants.Add(applicant);
        }

        public void UpdateApplicant(Applicant applicant)
        {
            var index = applicants.FindIndex(applicantExistant => applicantExistant.Id == applicant.Id);
            applicants[index] = applicant;
        }

        public void RemoveApplicant(Guid id)
        {
            var index = applicants.FindIndex(applicantExistant => applicantExistant.Id == id);
            applicants.RemoveAt(index);
        }
    }
}
