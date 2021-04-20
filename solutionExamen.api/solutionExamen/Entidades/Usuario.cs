using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace solutionExamen.Entidades
{
    public class Usuario
    {
        [Key]
        public string idUsuario { get; set; }
        public string contraseña { get; set; }
        public string tipoUsuario { get; set; }
    }
}
