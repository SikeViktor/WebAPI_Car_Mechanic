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
        public DateTime DateAndTime { get; set; }
        public Status Status { get; set; }


        public override string ToString()
        {
            return $"{CustomerName} : {CarType}({CarPlateNumber}) - {DateAndTime.Date}.{DateAndTime.Hour}:{DateAndTime.Minute}";
        }

    }

    public enum Status
    {
        [Description("Felvett munka")]
        FelvettMunka,
        [Description("Elvégzés alatt")]
        ElvegzesAlatt,
        [Description("Befejezett")]
        Befejezett
    }
}
