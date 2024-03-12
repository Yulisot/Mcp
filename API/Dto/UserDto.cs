using System.Text.Json.Serialization;

namespace  API.DTOS

{
    
    public class UserDto 
    {
        public int ClientId { get; set; }
        public int Id { get; set; }
        
        [JsonIgnore]
        public int CompanyId { get; set; }
        public long OvedId { get; set; }
        public long IdNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Leda { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DisabledAt { get; set; }
        public byte[] LastChange { get; set; }

        [JsonIgnore]
        public CompanyDto Company { get; set; }

        [JsonIgnore]
        public List<UserLoginDto> Logins { get; set; }

        [JsonIgnore]
        public List<EmpDto> Emps { get; set; }
    }

}