using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Data
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job {  get; set; }
        public string Phone { get; set; }

        public List<TestPatient> PaitentTests { get; set; }

    }
}
