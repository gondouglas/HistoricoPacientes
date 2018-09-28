using HistoricoPaciente.Infraestructure.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoPaciente.Infraestructure.Infra.DUMP
{
    public static class PacienteDump
    {

        public static List<Paciente> Init() {

            List<Paciente> pacientes = new List<Paciente>();

            for (int i = 0; i < 14; i++)
            {
                pacientes.Add(new Paciente() { Id = i, Nome = "Paciente número " + i, Idade = i + 10, Sexo = "M", Historicos = new List<Historico>() { new Historico() { Id = i, Descricao = "Descrição do paciente " + i, Date = DateTime.Now } }  });
            }
            return pacientes;
        }

    }
}
