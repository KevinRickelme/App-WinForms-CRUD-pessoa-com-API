using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testing_app.Model;

namespace API_consulta_Pessoa_Cadastrada.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
        

        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Endereco>(entity => 
            {
                entity.ToTable("Endereco");

                entity.HasKey(e => e.Id)
                .HasName("IdEndereco");

                entity.Property(e => e.Logradouro)
                .HasColumnType("varchar(200)")
                .HasColumnName("Logradouro");

                entity.Property(e => e.Numero)
                .HasColumnType("varchar(30)")
                .HasColumnName("Numero");

                entity.Property(e => e.Bairro)
                .HasColumnType("varchar(150)")
                .HasColumnName("Bairro");

                entity.Property(e => e.Cidade)
                .HasColumnType("varchar(150)")
                .HasColumnName("Cidade");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.ToTable("Pessoa");

                entity.HasKey(e => e.Id)
                .HasName("IdPessoa");

                entity.Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .HasColumnName("NomePessoa");

                entity.Property(e => e.RG)
                .HasColumnType("varchar(12)")
                .HasColumnName("RG");

                entity.Property(e => e.CPF)
                .HasColumnType("varchar(14)")
                .HasColumnName("CPF");
            });

            modelBuilder.Entity<Telefone>(entity => 
            {
                entity.ToTable("Telefone");
                entity.HasKey(e => e.Id)
                .HasName("IdTelefone");

                entity.Property(e => e.Numero)
                .HasColumnType("varchar(30)")
                .HasColumnName("Numero");

                entity.Property(e => e.DDD)
                .HasColumnType("int")
                .HasColumnName("DDD");

                entity.Property(e => e.TipoTelefone)
                .HasColumnType("int")
                .HasColumnName("TipoTelefone");
            });


        }
    }
}
