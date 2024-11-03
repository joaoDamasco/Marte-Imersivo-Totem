using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WPF_PIM_4.Visualizar
{
    public partial class VisualizarAdmin : UserControl
    {
        private Control activeTextBox;

        public VisualizarAdmin()
        {
            InitializeComponent();
            txbLogin.GotFocus += TextBox_GotFocus;
            txbSenha.GotFocus += TextBox_GotFocus;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            activeTextBox = sender as Control; // Atribui como Control
        }

        private void Teclado_Click(object sender, RoutedEventArgs e)
        {
            if (activeTextBox != null)
            {
                Button button = sender as Button;
                if (button != null)
                {                    
                    if (activeTextBox is PasswordBox passwordBox)
                    {                       
                        passwordBox.Password += button.Content.ToString();
                    }
                    else if (activeTextBox is TextBox textBox)
                    {
                        textBox.Text += button.Content.ToString();
                    }
                }
            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (activeTextBox != null)
            {
                if (activeTextBox is PasswordBox passwordBox && passwordBox.Password.Length > 0)
                {
                    // Remove o último caractere da senha
                    passwordBox.Password = passwordBox.Password.Substring(0, passwordBox.Password.Length - 1);
                }
                else if (activeTextBox is TextBox textBox && textBox.Text.Length > 0)
                {
                    // Remove o último caractere
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                }
            }
        }

        private void Limpar_Click(object sender, RoutedEventArgs e)
        {
            if (activeTextBox != null)
            {
                // Limpa o conteúdo do campo de texto
                if (activeTextBox is PasswordBox passwordBox)
                {
                    passwordBox.Clear();
                }
                else if (activeTextBox is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void EntrarLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = txbLogin.Text;
            string senha = txbSenha.Password;

            // Conexão com o banco de dados
            string connectionString = "Data Source=DESKTOP-4C3EO3O;Initial Catalog=DB_PIM;User ID=sa;Password=joaomel123;Encrypt=False;"; // Ajuste conforme necessário
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Administradores WHERE Login = @login AND Senha = @senha";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@senha", senha);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        // Se as credenciais estiverem corretas, abra a tela AdminControle
                        AdminControle adminControle = new AdminControle();
                        this.Content = adminControle;
                    }
                    else
                    {
                        MessageBox.Show("Senha ou login incorretos!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
