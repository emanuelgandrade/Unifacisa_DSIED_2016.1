using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Aluno
    {
        public int AlunoID { get; set; }

        public int CursoID { get; set; }
        
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
        public Curso Curso { get; set; }
        public IEnumerable<Avaliacao> Avaliacoes { get; set; }

    }
}
