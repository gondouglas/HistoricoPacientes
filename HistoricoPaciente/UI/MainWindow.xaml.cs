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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Tabela.ItemsSource = PacienteDAO.GetAll();
        }

        private void DuploClique(object sender, MouseButtonEventArgs e)
        {
            Paciente paciente = (Paciente)((DataGrid)sender).CurrentItem;
            HistoricoView historicoView = new HistoricoView(paciente);
            historicoView.ShowDialog();
            Tabela.ItemsSource = PacienteDAO.GetAll();

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            ModifyPacienteView modifyPacienteView = new ModifyPacienteView(null);
            modifyPacienteView.ShowDialog();
            Tabela.ItemsSource = PacienteDAO.GetAll();
        }

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            Paciente paciente = (Paciente)((DataGrid)Tabela).SelectedItem;
            ModifyPacienteView modifyPacienteView = new ModifyPacienteView(paciente);
            modifyPacienteView.ShowDialog();
            Tabela.ItemsSource = PacienteDAO.GetAll();
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            Paciente paciente = (Paciente)((DataGrid)Tabela).SelectedItem;
            PacienteDAO.Remove(paciente.Id);
            Tabela.ItemsSource = PacienteDAO.GetAll();
        }
    }
}
