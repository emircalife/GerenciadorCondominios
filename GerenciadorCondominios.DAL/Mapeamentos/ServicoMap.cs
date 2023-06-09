﻿using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.HasKey(s => s.ServicoId);
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Valor).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UsuarioID).IsRequired();

            builder.HasOne(s => s.Usuario).WithMany(s => s.Servicos).HasForeignKey(s => s.UsuarioID);
            builder.HasMany(s => s.ServicoPredios).WithOne(s => s.Servico);

            builder.ToTable("servicos");
        }
    }
}
