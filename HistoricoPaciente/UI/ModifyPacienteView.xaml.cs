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
    /// Interaction logic for ModifyPacienteView.xaml
    /// </summary>
    public partial class ModifyPacienteView : Window
    {
        Paciente paciente = new Paciente();

        public ModifyPacienteView(Paciente paciente)
        {
            InitializeComponent();

            if (paciente != null) {
                txt_id.Text = paciente.Id.ToString();
                txt_idade.Text = paciente.Idade.ToString();
                txt_Nome.Text = paciente.Nome.ToString();
                cmb_sexo.SelectedItem = paciente.Sexo.ToString();
                this.paciente = paciente;
            }

        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            paciente.Id = Convert.ToInt32(txt_id.Text);
            try
            {
                paciente.Idade = Convert.ToInt32(txt_idade.Text);
                paciente.Nome = txt_Nome.Text;
                paciente.Sexo = ((ComboBoxItem)(cmb_sexo.SelectedItem)).Tag.ToString();

                if (txt_id.Text.Equals("0"))
                {
                    PacienteDAO.Add(paciente);
                }
                else
                {
                    PacienteDAO.Update(paciente);
                }
                Close();
            }
            catch {
                MessageBox.Show("Idade tem que ser um inteiro", "Erro", MessageBoxButton.OK);
            }
        }
    }
}
