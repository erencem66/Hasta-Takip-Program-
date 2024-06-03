using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasta_Takip_Programı.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual List<Appointment> Appointment { get; set; }


    }
}
