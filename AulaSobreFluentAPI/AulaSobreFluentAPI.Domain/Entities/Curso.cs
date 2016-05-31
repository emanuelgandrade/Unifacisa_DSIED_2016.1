using System;
using System.Collections.Generic;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public DateTime DataCriacao { get; set; }

        public IEnumerable<Professor> Professores { get; set; }
        public IEnumerable<Aluno> Alunos { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }

    }
}
