using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppGames.App.Models.Plataforma
{
    public class PlataformaEdicaoViewModel
    {
        [Required(ErrorMessage = "Informe o id da plataforma")]
        public int IdPlataforma { get; set; }

        [Required(ErrorMessage = "Informe o nome da plataforma")]
        public string Nome { get; set; }
    }
}
