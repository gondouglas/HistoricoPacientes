using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoPaciente.Infraestructure.Infra.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public List<Historico> Historicos { get; set; }
    }
}
