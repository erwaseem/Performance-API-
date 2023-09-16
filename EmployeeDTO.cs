using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Model
{
    public class EmployeeDTO
    {
        public int EmpId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public string? Email { get; set; }
        public string? DOB { get; set; }
        public string? Mobile { get; set; }
        public string? Address1 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int Zipcode { get; set; }
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
