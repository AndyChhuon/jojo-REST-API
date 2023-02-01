using JobApplicants.Models;

namespace JobApplicants.Repositories
{
    public interface IInMemItemsRepository
    {
        Applicant GetApplicant(Guid id);
        IEnumerable<Applicant> GetApplicants();
        void AddApplicant(Applicant applicant);
        void UpdateApplicant(Applicant applicant);
        void RemoveApplicant(Guid applicantId);


    }
}