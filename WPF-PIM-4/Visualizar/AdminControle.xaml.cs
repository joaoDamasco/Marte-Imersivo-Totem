using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WPF_PIM_4.Visualizar
{
    public partial class AdminControle : UserControl
    {
        private string connectionString = "Data Source=DESKTOP-4C3EO3O;Initial Catalog=DB_PIM;User ID=sa;Password=joaomel123;Encrypt=False;";

        public AdminControle()
        {
            InitializeComponent();
        }

        public class RegistroUnificado
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Resposta { get; set; }
            public string Sugestao { get; set; }
            public string Pergunta { get; set; } 
        }


        private void Buscar_Click(object sender, RoutedEventArgs e)
        {
            var dadosEmails = new List<RegistroUnificado>();
            var dadosSugestoes = new List<RegistroUnificado>();
            var dadosRespostas = new List<RegistroUnificado>();
            var dadosPerguntas = new List<RegistroUnificado>(); // Nova lista para perguntas

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Buscando Emails
                string queryEmails = "SELECT Id, Email FROM Emails";
                SqlCommand commandEmails = new SqlCommand(queryEmails, connection);
                SqlDataReader readerEmails = commandEmails.ExecuteReader();

                while (readerEmails.Read())
                {
                    dadosEmails.Add(new RegistroUnificado
                    {
                        Id = readerEmails.GetInt32(0),
                        Email = readerEmails.IsDBNull(1) ? null : readerEmails.GetString(1)
                    });
                }
                readerEmails.Close();

                // Buscando Sugestões
                string querySugestoes = "SELECT Id, Sugestao FROM Sugestoes";
                SqlCommand commandSugestoes = new SqlCommand(querySugestoes, connection);
                SqlDataReader readerSugestoes = commandSugestoes.ExecuteReader();

                while (readerSugestoes.Read())
                {
                    dadosSugestoes.Add(new RegistroUnificado
                    {
                        Id = readerSugestoes.GetInt32(0),
                        Sugestao = readerSugestoes.IsDBNull(1) ? null : readerSugestoes.GetString(1)
                    });
                }
                readerSugestoes.Close();

                // Buscando Respostas e Perguntas
                string queryRespostas = "SELECT Id, Resposta, Pergunta FROM QuestionarioRespostas"; // Incluindo Pergunta na consulta
                SqlCommand commandRespostas = new SqlCommand(queryRespostas, connection);
                SqlDataReader readerRespostas = commandRespostas.ExecuteReader();

                while (readerRespostas.Read())
                {
                    dadosRespostas.Add(new RegistroUnificado
                    {
                        Id = readerRespostas.GetInt32(0),
                        Resposta = readerRespostas.IsDBNull(1) ? null : readerRespostas.GetString(1),
                        Pergunta = readerRespostas.IsDBNull(2) ? null : readerRespostas.GetString(2) // Capturando Pergunta
                    });
                }
            }

            dataGridEmails.ItemsSource = dadosEmails;
            dataGridSugestoes.ItemsSource = dadosSugestoes;
            dataGridRespostas.ItemsSource = dadosRespostas; // Exibe respostas e perguntas no mesmo DataGrid
        }


        private void dataGridEmails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridEmails.SelectedItem is RegistroUnificado email)
            {
                txtEmail.Text = email.Email;
                txtEmail.IsReadOnly = false; // Permite edição do campo email
            }
        }

        private void dataGridSugestoes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridSugestoes.SelectedItem is RegistroUnificado sugestao)
            {
                // Exibe a sugestão ou realiza alguma ação
                MessageBox.Show($"Sugestão selecionada: {sugestao.Sugestao}");
            }
        }

        private void dataGridRespostas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridRespostas.SelectedItem is RegistroUnificado resposta)
            {
                // Exibe a resposta ou realiza alguma ação
                MessageBox.Show($"Resposta selecionada: {resposta.Resposta}");
            }
        }

        private void AtualizarEmail_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEmails.SelectedItem is RegistroUnificado registro)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Emails SET Email = @Email WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Id", registro.Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("E-mail atualizado com sucesso.");
                        Buscar_Click(sender, e); // Atualiza a lista após a atualização
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o e-mail.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um email para atualizar.");
            }
        }

        private void DeletarEmail_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEmails.SelectedItem is RegistroUnificado registro)
            {
                MessageBoxResult confirmDelete = MessageBox.Show("Tem certeza que deseja deletar este email?", "Confirmação", MessageBoxButton.YesNo);
                if (confirmDelete == MessageBoxResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Emails WHERE Id = @Id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", registro.Id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Email deletado com sucesso.");
                    }
                    Buscar_Click(sender, e); // Atualiza a lista após a deleção
                }
            }
            else
            {
                MessageBox.Show("Selecione um email para deletar.");
            }
        }

        private void DeletarSugestao_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridSugestoes.SelectedItem is RegistroUnificado registro)
            {
                MessageBoxResult confirmDelete = MessageBox.Show("Tem certeza que deseja deletar esta sugestão?", "Confirmação", MessageBoxButton.YesNo);
                if (confirmDelete == MessageBoxResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Sugestoes WHERE Id = @Id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", registro.Id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sugestão deletada com sucesso.");
                    }
                    Buscar_Click(sender, e); // Atualiza a lista após a deleção
                }
            }
            else
            {
                MessageBox.Show("Selecione uma sugestão para deletar.");
            }
        }

        private void DeletarResposta_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridRespostas.SelectedItem is RegistroUnificado registro)
            {
                MessageBoxResult confirmDelete = MessageBox.Show("Tem certeza que deseja deletar a resposta desta sugestão?", "Confirmação", MessageBoxButton.YesNo);
                if (confirmDelete == MessageBoxResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM QuestionarioRespostas WHERE Id = @Id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", registro.Id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Resposta deletada com sucesso.");
                    }
                    Buscar_Click(sender, e); // Atualiza a lista após a deleção
                }
            }
            else
            {
                MessageBox.Show("Selecione uma resposta para deletar.");
            }
        }
    }
}
