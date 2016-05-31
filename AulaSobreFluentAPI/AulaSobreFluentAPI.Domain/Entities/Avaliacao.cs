using System.Collections.Generic;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Avaliacao
    {
        public int AvaliacaoID { get; set; }
        public Disciplina Disciplina { get; set; }
        public Aluno Aluno { get; set; }
        public IEnumerable<Questao> Questoes { get; set; }

    }
}
