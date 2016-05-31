using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public int CursoID { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
        public Curso Curso { get; set; }

    }
}
