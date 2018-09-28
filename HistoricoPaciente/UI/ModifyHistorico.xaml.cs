using HistoricoPaciente.Infraestructure.Infra.DAO;
using HistoricoPaciente.Infraestructure.Infra.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for ModifyHistorico.xaml
    /// </summary>
    public partial class ModifyHistorico : Window
    {
        Paciente paciente = new Paciente();
        Historico historico = new Historico();

        public ModifyHistorico(Paciente paciente, Historico historico)
        {
            InitializeComponent();

            if (historico != null) {
                txt_descricao.Text = historico.Descricao;
                txt_id.Text = historico.Id.ToString();
                this.historico = historico;
            }
            this.paciente = paciente;
        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            historico.Id = Convert.ToInt32(txt_id.Text);
            historico.Descricao = txt_descricao.Text;
            historico.Date = DateTime.Now;
            if (txt_id.Text.Equals("0"))
            {
                historico.Id = new Random().Next();
                paciente.Historicos.Add(historico);
                PacienteDAO.Update(paciente);
            }
            else {
                paciente.Historicos[historico.Id] = historico;
                PacienteDAO.Update(paciente);
            }
            Close();
        }
    }
}
