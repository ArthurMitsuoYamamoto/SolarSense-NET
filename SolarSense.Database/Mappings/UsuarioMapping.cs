﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarSense.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSense.Database.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Nome da tabela
            builder
                .ToTable("T_SO_USUARIO");

            // Chave primária
            builder
                .HasKey(x => x.Id);

            // Nome do usuário
            builder
                .Property(x => x.Nome)
                .HasMaxLength(50)
                .HasColumnName("NOME")
                .IsRequired();

            // Email
            builder
                .Property(x => x.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL")
                .IsRequired();

            // Senha 
            builder
                .Property(x => x.Senha)
                .HasMaxLength(255)
                .HasColumnName("SENHA")
                .IsRequired();

            // Tipo de usuário
            builder
                .Property(x => x.Tipo)
                .HasColumnName("TIPO")
                .HasMaxLength(7)
                .IsRequired();


            // Notificações
            builder
                .Property(x => x.Notificacoes)
                .HasColumnName("NOTIFICACOES")
                .HasMaxLength(3)
                .IsRequired();


            // Data de cadastro
            builder
                .Property(x => x.DataCadastro)
                .HasColumnName("DATACADASTRO")
                .IsRequired();
        }
    }
}
