namespace API.Customer

{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public string Url { get; set; }
        public string ParamJsonClient { get; set; }
        public byte[] LastChange { get; set; }
        public List<Company> Companies { get; set; }
    }

    public class Company
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Header { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public long? TikNikuiim { get; set; }
        public long? Hp { get; set; }
        public short? P43_01_ByShifts { get; set; }
        public short? P43_Semel_Work_Item { get; set; }
        public short? IdType { get; set; }
        public short MessageOption { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public string ParamJsonComp { get; set; }
        public byte[] LastChange { get; set; }

        public Client Client { get; set; }
        public List<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CompanyId { get; set; }
        public long OvedId { get; set; }
        public long IdNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Leda { get; set; }
        public string Tel { get; set; }
        public string VerificationCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public byte[] LastChange { get; set; }

        public Company Company { get; set; }
        public List<UserLogin> Logins { get; set; }
        public List<Emp> Emps { get; set; }
    }
    public class UserLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LoginTime { get; set; }

        public User User { get; set; }
    }

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
    public class Paycheck
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public long OvedId { get; set; }
        public int EmpId { get; set; }
        public DateTime CompanyMifalDate { get; set; }
        public DateTime CompanyOvedDate { get; set; }
        public short Year { get; set; }
        public short Month { get; set; }
        public string Data { get; set; }
        public byte[] LastChange { get; set; }
        public int? ExternalType { get; set; }

        public Emp Employee { get; set; }
    }
}