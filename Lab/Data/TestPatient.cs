using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data
{
    public class TestPatient
    {
        public int Id { get; set; }
        public int TestId { get;set; }
        public Test test { get;set; }
        public int PatientId { get;set; }
        public Patient Patient { get;set; }
        public string Doctor { get; set; }

        public float PriceAfterDiscount { get;set;}

        public DateTime Date { get; set; }
    }
}
