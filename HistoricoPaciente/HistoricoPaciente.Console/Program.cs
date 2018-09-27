
using HistoricoPaciente.Infraestructure.Infra.DAO;
using HistoricoPaciente.Infraestructure.Infra.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoPaciente.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //paciente.Id = 1;
            //paciente.nome = "Douglas Gonçalves";
            //paciente.idade = 20;
            //paciente.sexo = "M";

            PacienteDAO pacienteDAO = new PacienteDAO();

            //pacienteDAO.Save(paciente);

            System.Console.Write(pacienteDAO.GetAll());
        }
    }
}
