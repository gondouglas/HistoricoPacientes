using System.Data.Entity;


namespace HistoricoPaciente.Infraestructure.Infra.EDM
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class Context : DbContext
    {

        public Context() : base("HistoricoPacienteEntities") { }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Historico> Historicos { get; set; }
    }
}
