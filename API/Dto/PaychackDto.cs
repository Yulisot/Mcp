namespace API.DTOS
{
    public class PaycheckDto
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

        public EmpDto Employee { get; set; }

    }

}