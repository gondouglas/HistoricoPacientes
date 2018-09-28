using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoPaciente.Infraestructure.Infra.Entities
{
    public class Historico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Date { get; set; }


        public override string ToString()
        {
            return Date.ToString() + Descricao.ToString();
        }
    }
}
