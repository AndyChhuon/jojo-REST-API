namespace JobApplicants.Models
{
    public record Applicant
    {
        public Guid Id { get; init; }
        public String Name { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

        
    }
}
