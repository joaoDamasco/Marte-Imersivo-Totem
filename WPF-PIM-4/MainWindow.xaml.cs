using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_PIM_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
            RadioButtonInicial.IsChecked = true;

        }

        private void pnlBarraControle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var telaVisualizacao =  new Visualizar.AtulizarVisualizacao();

            MainContentControl.Content = telaVisualizacao;
        }

        private void RadioButton_Mapa(object sender, RoutedEventArgs e)
        {
            var telaMapa = new Visualizar.VisualizarMapa();

            MainContentControl.Content = telaMapa;
        }

        private void RadioButtonHistoria_Checked(object sender, RoutedEventArgs e)
        {
            var telaHistoria = new Visualizar.VisualizarHistoria();
            MainContentControl.Content = telaHistoria;
        }

        private void RadioButtonAvaliacao_Checked(object sender, RoutedEventArgs e)
        {
            var telaAvaliacao = new Visualizar.QuestionarioAvaliacao();
            MainContentControl.Content = telaAvaliacao;
        }

        private void ButaoEmail_Checked(object sender, RoutedEventArgs e)
        {
            var telaEmail = new Visualizar.VisualizarEmail();
            MainContentControl.Content = telaEmail;
        }

        private void BotaoAdmin_Checked(object sender, RoutedEventArgs e)
        {
            var telaAdmin = new Visualizar.VisualizarAdmin();
            MainContentControl.Content = telaAdmin;
        }
    }
}