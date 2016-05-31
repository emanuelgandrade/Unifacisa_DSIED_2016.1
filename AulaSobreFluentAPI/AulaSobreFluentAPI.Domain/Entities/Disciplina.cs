using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public Curso Curso { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<Aluno> Alunos { get; set; }
        public IEnumerable<Avaliacao> Avaliacoes { get; set; }


    }
}
