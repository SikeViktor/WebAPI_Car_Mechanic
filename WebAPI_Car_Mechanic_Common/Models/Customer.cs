using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Car_Mechanic_Common.Models
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CarType { get; set; }
        [Required]
        public string CarPlateNumber { get; set; }
        [Required]
        public string ProblemDescription { get; set; }
        [Required]
        public DateTime DateAndTime { get; set; }
        [Required]
        public string SelectedStatus { get; set; }

    }

}
