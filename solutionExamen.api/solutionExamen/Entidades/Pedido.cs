﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace solutionExamen.Entidades
{
    public class Pedido
    {
        [Key] 
        public int numero { get; set;}
        public string fecha { get; set; }
        public string proveedor { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }

    }
}
