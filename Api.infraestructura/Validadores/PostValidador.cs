﻿using Api.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.infraestructura.Validadores
{
    public class PostValidador : AbstractValidator<PublicacionDTO>
    {
        public PostValidador()
        {
            RuleFor(Publicacion => Publicacion.Descripcion)
                .NotNull()
                .Length(10, 500);
            RuleFor(Publicacion => Publicacion.Fecha)
                .NotNull()
                .LessThan(DateTime.Now);
        }
    }
}
