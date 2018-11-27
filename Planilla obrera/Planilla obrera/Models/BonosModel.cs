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

    [Required]
    [Display(Name ="ID obrero")]
    public string idObreroE { get; set; }

    [Required]
    [Display(Name ="Nuevo monto")]
    public string montoBonoE { get; set; }

    [Required]
    [Display(Name ="Valor por hora")]
    public string valorHora { get; set; }

    [Required]
    [Display(Name ="Puesto")]
    public string puesto { get; set; }

    [Required]
    [Display(Name ="Tipo jornada")]
    public string tipoJornada { get; set; }

    [Required]
    [Display(Name ="Nuevo monto")]
    public string nuevoMonto { get; set; }
}
