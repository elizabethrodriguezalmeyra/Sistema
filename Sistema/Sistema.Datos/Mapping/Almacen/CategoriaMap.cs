﻿using Sistema.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistema.Datos.Mapping.Almacen
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria").HasKey( c => c.idcategoria);
            _ = builder.Property(c => c.nombre).HasMaxLength(50);
            builder.Property(c => c.descripcion).HasMaxLength(256);
        }
    }
}
