using JobApplicants.Models;
using MongoDB.Driver;

namespace JobApplicants.Repositories
{
    public class MongoDbItemsRepository : IInMemItemsRepository
    {
        private const string databaseName = "JobApplicants";
        private const string collectionName = "Applicants";

        private readonly IMongoCollection<Applicant> applicantsCollection;
        public MongoDbItemsRepository(IMongoClient mongoClient) {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            applicantsCollection = database.GetCollection<Applicant>(collectionName);
        }
        public void AddApplicant(Applicant applicant)
        {
            applicantsCollection.InsertOne(applicant);
        }

        public Applicant GetApplicant(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Applicant> GetApplicants()
        {
            throw new NotImplementedException();
        }

        public void RemoveApplicant(Guid applicantId)
        {
            throw new NotImplementedException();
        }

        public void UpdateApplicant(Applicant applicant)
        {
            throw new NotImplementedException();
        }
    }
}
