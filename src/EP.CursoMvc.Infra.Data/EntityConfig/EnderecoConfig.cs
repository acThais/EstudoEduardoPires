using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entities;

namespace EP.CursoMvc.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Complemento)
                .HasMaxLength(50);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .HasMaxLength(100);

            //1:n
            HasRequired(e => e.Cliente)
                .WithMany(c => c.Enderecos)
                .HasForeignKey(e => e.ClienteId);


            ToTable("Enderecos");

        }
    }
}
