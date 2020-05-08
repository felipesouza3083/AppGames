﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGames.App.Models.Plataforma
{
    public class PlataformaCadastroViewModel
    {
        [Required(ErrorMessage = "Informe o nome da plataforma")]
        public string Nome { get; set; }
    }
}
