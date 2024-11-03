using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WPF_PIM_4.Visualizar
{
    public partial class VisualizarEmail : UserControl
    {
        private TextBox _ativarCaixa;

        public VisualizarEmail()
        {
            InitializeComponent();
                      

            txbSugestao.GotFocus += TextBox_GotFocus;
            txbEmail.GotFocus += TextBox_GotFocus;
        }

        private bool _isCapsLockEnabled = false;

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            _ativarCaixa = sender as TextBox;
        }

        private void CapsLock_Click(object sender, RoutedEventArgs e)
        {
            _isCapsLockEnabled = !_isCapsLockEnabled; 
            Button capsLockButton = sender as Button;

            // Altera o texto do botão para refletir o estado do Caps Lock
            if (_isCapsLockEnabled)
            {
                capsLockButton.Content = "abc"; 
                SetKeyboardButtonsToLower();
            }
            else
            {
                capsLockButton.Content = "CAPS"; 
                SetKeyboardButtonsToUpper();
            }
        }



        private void VirtualKeyboard_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null && _ativarCaixa != null)
            {
                string input = button.Content.ToString();

                // Se o Caps Lock estiver ativado, converte para maiúsculas
                if (_isCapsLockEnabled)
                {
                    input = input.ToLower(); // Converte para maiúscula
                }
                else
                {
                    input = input.ToUpper(); // Converte para minúscula
                }

                _ativarCaixa.Text += input; // Adiciona o texto ao TextBox ativo
                _ativarCaixa.CaretIndex = _ativarCaixa.Text.Length; // Move o cursor para o final
            }
        }

        // Método para o botão de Backspace
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (_ativarCaixa != null && _ativarCaixa.Text.Length > 0)
            {
                _ativarCaixa.Text = _ativarCaixa.Text.Substring(0, _ativarCaixa.Text.Length - 1);
                _ativarCaixa.CaretIndex = _ativarCaixa.Text.Length;
            }
        }

        private void Space_Click(object sender, RoutedEventArgs e)
        {
            if (_ativarCaixa != null)
            {
                _ativarCaixa.Text += " "; // Adiciona um espaço ao TextBox ativo
                _ativarCaixa.CaretIndex = _ativarCaixa.Text.Length; // Move o cursor para o final
            }
        }


        // Método para o botão Clear
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (_ativarCaixa != null)
            {
                _ativarCaixa.Clear();
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string sugestao = txbSugestao.Text;
            string email = txbEmail.Text;

            string connectionString = "Data Source=DESKTOP-4C3EO3O;Initial Catalog=DB_PIM;User ID=sa;Password=joaomel123;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Inserir sugestão
                string querySugestao = "INSERT INTO Sugestoes (Sugestao) VALUES (@Sugestao)";
                SqlCommand commandSugestao = new SqlCommand(querySugestao, connection);
                commandSugestao.Parameters.AddWithValue("@Sugestao", sugestao);

                try
                {
                    // Executar o comando para salvar a sugestão
                    commandSugestao.ExecuteNonQuery();

                    // Se o email não estiver vazio, salve-o
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        string queryEmail = "INSERT INTO Emails (Email) VALUES (@Email)";
                        SqlCommand commandEmail = new SqlCommand(queryEmail, connection);
                        commandEmail.Parameters.AddWithValue("@Email", email);

                        commandEmail.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados salvos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar dados: " + ex.Message);
                }
            }
        }


        // Método para alterar todos os botões para letras minúsculas
        private void SetKeyboardButtonsToLower()
        {
            LetraA.Content = "a";
            LetraB.Content = "b";
            LetraC.Content = "c";
            LetraD.Content = "d";
            LetraE.Content = "e";
            LetraF.Content = "f";
            LetraG.Content = "g";
            LetraH.Content = "h";
            LetraI.Content = "i";
            LetraJ.Content = "j";
            LetraK.Content = "k";
            LetraL.Content = "l";
            LetraM.Content = "m";
            LetraN.Content = "n";
            LetraO.Content = "o";
            LetraP.Content = "p";
            LetraQ.Content = "q";
            LetraR.Content = "r";
            LetraS.Content = "s";
            LetraT.Content = "t";
            LetraU.Content = "u";
            LetraV.Content = "v";
            LetraW.Content = "w";
            LetraX.Content = "x";
            LetraY.Content = "y";
            LetraZ.Content = "z";
            }

        // Método para alterar todos os botões para letras maiúsculas
        private void SetKeyboardButtonsToUpper()
        {
            LetraA.Content = "A";
            LetraB.Content = "B";
            LetraC.Content = "C";
            LetraD.Content = "D";
            LetraE.Content = "E";
            LetraF.Content = "F";
            LetraG.Content = "G";
            LetraH.Content = "H";
            LetraI.Content = "I";
            LetraJ.Content = "J";
            LetraK.Content = "K";
            LetraL.Content = "L";
            LetraM.Content = "M";
            LetraN.Content = "N";
            LetraO.Content = "O";
            LetraP.Content = "P";
            LetraQ.Content = "Q";
            LetraR.Content = "R";
            LetraS.Content = "S";
            LetraT.Content = "T";
            LetraU.Content = "U";
            LetraV.Content = "V";
            LetraW.Content = "W";
            LetraX.Content = "X";
            LetraY.Content = "Y";
            LetraZ.Content = "Z";
        }
    }
}