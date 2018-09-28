using HistoricoPaciente.Infraestructure.Infra.DUMP;
using HistoricoPaciente.Infraestructure.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricoPaciente.Infraestructure.Infra.DAO
{
    public static class PacienteDAO
    {
        public static List<Paciente> Pacientes = PacienteDump.Init();

        public static List<Paciente> GetAll() {
            return Pacientes.ToList();
        }

        public static void Add(Paciente paciente) {
            paciente.Id = Pacientes.Max(t => t.Id);
            Pacientes.Add(paciente);
        }

        public static void Remove(int id) {
            Pacientes.Remove(Pacientes.Find(x => x.Id == id));
        }

        public static void Update(Paciente paciente) {
            Pacientes[Pacientes.Find(x => x.Id == paciente.Id).Id] = paciente;
        }

        public static Paciente findById(int id) {
            return Pacientes.Find(x => x.Id == id);
        }
    }
}
