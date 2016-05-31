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
        //    //Remove a convens�o de pluralizar os nomes das tabelas
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    //Defino que, sempre que o nome da classe + ID, o EF definir� como chave prim�ria
        //    modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "ID").Configure(p => p.IsKey());

        //    //Definindo do tipo e do tamanho dos campos que ser�o criados na tabela.
        //    modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); //Para o tipo de dados
        //    modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100)); //Para o tamanho
            
        //}

        //// M�todo respons�vel por realizar modifica��es em tempo de execu��o dos valores, caso necess�rio
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