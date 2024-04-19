using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Data.Models.ViewModels
{
    public enum EnumOrderState
    {
        [Display(Name ="Waiting")] Waiting,
        [Display(Name ="Completed")] Completed,
    }
}
