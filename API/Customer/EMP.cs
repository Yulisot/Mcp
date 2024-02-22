namespace API.Customer

{

    public class Emp
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
        public string Email { get; set; }
        public string Tel { get; set; }
        public string AdditionalTel { get; set; }
        public string City { get; set; }
        public long? CityKod { get; set; }
        public string Address { get; set; }
        public string HouseNo { get; set; }
        public int? ApartmentNo { get; set; }
        public long? ZipCode { get; set; }
        public long? MailOfficeBox { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public int? HealthOrganization { get; set; }
        public DateTime? Alia { get; set; }
        public short? IsIsraelCitizen { get; set; }
        public short? HaverKibutz { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public byte[] LastChange { get; set; }

        public User User { get; set; }
        public List<Paycheck> Paychecks { get; set; }
    }
}