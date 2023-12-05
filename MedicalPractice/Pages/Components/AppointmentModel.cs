using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalPractice.Pages.Components
{
    public class AppointmentModel
    {
        [Required(ErrorMessage = "Patient Name is required.")]
        public string PatientName { get; set; }

        [Required(ErrorMessage = "Appointment Date is required.")]
        public DateTime AppointmentDate { get; set; }

    }
}
