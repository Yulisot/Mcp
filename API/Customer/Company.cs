namespace API.Customer

{
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
}