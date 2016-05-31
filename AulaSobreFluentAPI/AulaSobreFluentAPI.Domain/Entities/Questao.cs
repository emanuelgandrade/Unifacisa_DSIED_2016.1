using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Questao
    {
        public int QuestaoID { get; set; }
        public string Descricao { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public IEnumerable<Alternativa> Alternativas { get; set; }
    }
}
