﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
<<<<<<< HEAD
        public int Id { set; get; }
        public string Codigo { set; get; }
=======
>>>>>>> 2b90c7104fc2b006d26a2e007a8799d344c97612
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public float Precio { set; get; }
        public Marca Marca { set; get; }
        public Categoria Categoria { set; get; }
<<<<<<< HEAD
        public Imagen Imagen { set; get; }
        public bool Estado { set; get; }

        public Articulo()
        {
            Estado = true;
        }
=======
        public List<Imagen> Imagenes { set; get; }
>>>>>>> 2b90c7104fc2b006d26a2e007a8799d344c97612
    }
}

