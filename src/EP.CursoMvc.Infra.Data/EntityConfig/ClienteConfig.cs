using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EP.CursoMvc.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);
            //HasKey(c =>new (c.ClienteId, c.CPF));

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
                //.HasColumnName("Nome p banco")

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.DataCadastro)
                .IsRequired();
            
            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(c => c.Ativo)
                .IsRequired();

            ToTable("Clientes");


        }
    }
}
