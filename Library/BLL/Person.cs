using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IPerson
    {
        [Required]
        string F_Name { get; set; }
        [Required]
        string L_Name { get; set; }
        [Required]
        byte Gender { get; set; }
        [Required]
        string National_Number { get; set; }
        [Required]
        string Phone_Number1 { get; set; }
        [Required]
        string Phone_Number2 { get; set; }
        [Required]
        DateTime Birthdate { get; set; }
        [Required]
        DateTime Date_Time_Insert { get; set; }
        [Required]
        string Solar_Date_Time_Insert { get; set; }

    }
}
