using AulaSobreFluentAPI.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AulaSobreFluentAPI.Infra.Data.EntityConfiguration
{
    public class CursoConfiguration: EntityTypeConfiguration<Curso>
    {
        public CursoConfiguration()
        {
            //Define quem é a chave primária
            HasKey(c => c.CursoID);
            // Define que a propriedade Nome é obrigatória e que o seu tamanho máximo é de 150
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            //Define que a pripriedade Area é obrigatória
            Property(c => c.Area).IsRequired();
        }
    }
}
