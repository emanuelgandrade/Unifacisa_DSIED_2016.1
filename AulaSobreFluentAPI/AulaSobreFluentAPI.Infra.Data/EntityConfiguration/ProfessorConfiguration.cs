using AulaSobreFluentAPI.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AulaSobreFluentAPI.Infra.Data.EntityConfiguration
{
    public class ProfessorConfiguration : EntityTypeConfiguration<Professor>
    {
        public ProfessorConfiguration()
        {
            HasKey(p => p.ProfessorID);
            // Para você se basear - http://netcoders.com.br/blog/mapeamento-com-entity-framework-code-first-fluent-api-parte-1/
            HasRequired(p => p.Curso).WithMany().HasForeignKey(p => p.CursoID);
        }
    }
}
