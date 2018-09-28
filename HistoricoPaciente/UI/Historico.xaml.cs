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
    /// Interaction logic for Historico.xaml
    /// </summary>
    public partial class HistoricoView : Window
    {
        Paciente paciente;

        public HistoricoView(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            HistoricoDataGrid.ItemsSource = paciente.Historicos;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            ModifyHistorico modifyHistorico = new ModifyHistorico(paciente, null);
            modifyHistorico.ShowDialog();
            HistoricoDataGrid.ItemsSource = PacienteDAO.findById(paciente.Id).Historicos;
        }

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            Historico historico = (Historico)((DataGrid)HistoricoDataGrid).SelectedItem;
            ModifyHistorico modifyHistorico = new ModifyHistorico(paciente, historico);
            modifyHistorico.ShowDialog();
            HistoricoDataGrid.ItemsSource = PacienteDAO.findById(paciente.Id).Historicos;
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            Historico historico = (Historico)((DataGrid)HistoricoDataGrid).SelectedItem;
            paciente.Historicos.Remove(historico);
            PacienteDAO.Update(paciente);
            HistoricoDataGrid.ItemsSource = PacienteDAO.findById(paciente.Id).Historicos;

        }
    }
}
