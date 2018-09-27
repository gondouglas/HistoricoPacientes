using HistoricoPaciente.Infra.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoPaciente.Infra.Domain.Entities
{
    public class Paciente : BaseEntity
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char sexo { get; set; }
    }
}
