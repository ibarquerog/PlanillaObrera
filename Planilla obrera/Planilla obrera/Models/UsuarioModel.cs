using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class UsuarioModel
    {
    [Required]
    [Display(Name = "ID Obrero")]
    public string idObrero { get; set; }

    }
