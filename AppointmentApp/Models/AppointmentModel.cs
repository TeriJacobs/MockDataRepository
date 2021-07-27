using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentApp.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20, MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }

        [DisplayName("Patient's email")]
        public string PatientEmail { get; set; }

        [DisplayName("Patient's contact number")]
        public double PatientContactNumber { get; set; }

        [DisplayName("Patient's street adress")]
        public string PatientStreetAddress { get; set; }

        [DisplayName("Patient's city")]
        public string PatientCityAddress { get; set; }

        [DisplayName("Patient's zip code")]
        public int PatientZipCodeAddress { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }
        
        [DataType(DataType.Currency)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Primary Doctor's last name")]
        public string DoctorName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's percieved level of pin 1 -10")]
        public int PainLevel { get; set; }
    }

}
