namespace API.DTOS
{
    public class EmpDto
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public long IdNum { get; set; }
        public long EmpNo { get; set; }
        public int? Dept { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameEng { get; set; }
        public string LastNameEng { get; set; }

        public UserDto User { get; set; }
        public List<PaycheckDto> Paychecks { get; set; }
    }
}