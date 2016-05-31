using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreFluentAPI.Domain.Entities
{
    public class Alternativa
    {
        public int AlternativaID { get; set; }
        public Questao Questao { get; set; }

        public string Descricao { get; set; }

        public bool ECorreta { get; set; }

    }
}
