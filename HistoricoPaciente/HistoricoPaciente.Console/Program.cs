
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
            System.Console.Write(PacienteDAO.Pacientes);
        }
    }
}
