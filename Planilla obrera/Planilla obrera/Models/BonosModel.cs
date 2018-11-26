using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


public class BonosModel
{
    [Required]
    [Display(Name = "ID Obrero")]
    public string idObrero { get; set; }
    
    [Required]
    [Display(Name ="Monto del Bono")]
    public string montoBono { get; set; }
}
