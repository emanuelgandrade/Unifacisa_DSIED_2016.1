namespace AulaSobreFluentAPI.Infra.Data.Context
{
    using Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class SimuladoContext : DbContext
    {
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Disciplina> Disciplinas { get; set; }
        public virtual DbSet<Avaliacao> Avaliacoes { get; set; }
        public virtual DbSet<Questao> Questoes { get; set; }
        public virtual DbSet<Alternativa> Alternativas { get; set; }

        public SimuladoContext()
            : base("name=ProjetoSistemaDeSimulado")
        {
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Remove a convensão de pluralizar os nomes das tabelas
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    //Defino que, sempre que o nome da classe + ID, o EF definirá como chave primária
        //    modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());

        //    //Definindo do tipo e do tamanho dos campos que serão criados na tabela.
        //    modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); //Para o tipo de dados
        //    modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100)); //Para o tamanho
            
        //}

        //// Método responsável por realizar modificações em tempo de execução dos valores, caso necessário
        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }

        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }

        //    return base.SaveChanges();
        //}

    }
}