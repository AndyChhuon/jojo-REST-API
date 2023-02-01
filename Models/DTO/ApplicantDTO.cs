namespace JobApplicants.Models.DTO
{
    public record ApplicantDTO
    {
 
        public Guid Id { get; init; }
        public String Name { get; init; }
        public DateTimeOffset CreatedDate { get; init; }

        
    }
}
