﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Api.Core.Entidades
{
    public partial class Usuario : BaseEntidad
    {
        public Usuario()
        {
            Comentario = new HashSet<Comentario>();
            Publicacion = new HashSet<Publicacion>();
        }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<Comentario> Comentario { get; set; }
        public virtual ICollection<Publicacion> Publicacion { get; set; }
    }
}
