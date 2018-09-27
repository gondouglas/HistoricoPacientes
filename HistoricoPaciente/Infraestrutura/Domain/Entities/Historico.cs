using HistoricoPaciente.Infra.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoPaciente.Infra.Domain.Entities
{
    public class Historico : BaseEntity
    {
        public Paciente Paciente { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
    }
}
