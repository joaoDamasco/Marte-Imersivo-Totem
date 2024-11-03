using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace WPF_PIM_4.Visualizar
{
    public partial class QuestionarioAvaliacao : UserControl
    {
        public QuestionarioAvaliacao()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string resposta1 = GetSelectedResponse(1);
            string resposta2 = GetSelectedResponse(2);
            string resposta3 = GetSelectedResponse(3);

            if (string.IsNullOrEmpty(resposta1) || string.IsNullOrEmpty(resposta2) || string.IsNullOrEmpty(resposta3))
            {
                MessageBox.Show("Por favor, selecione uma resposta para todas as perguntas.", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SaveResponsesToDatabase("Como foi sua experiência?", resposta1);
            SaveResponsesToDatabase("Como você avaliaria a qualidade das informações?", resposta2);
            SaveResponsesToDatabase("Como nos avaliaria no geral?", resposta3);

            MessageBox.Show("Respostas salvas com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);

            // Exibe o total de respostas já armazenadas no banco
            ExibirResultadoTotalizado();
        }

        private string GetSelectedResponse(int questionNumber)
        {
            return GetCheckedRadioButtonContent(questionNumber);
        }

        private string GetCheckedRadioButtonContent(int questionNumber)
        {
            WrapPanel currentWrapPanel = null;

            switch (questionNumber)
            {
                case 1:
                    currentWrapPanel = wrapPanel1;
                    break;
                case 2:
                    currentWrapPanel = wrapPanel2;
                    break;
                case 3:
                    currentWrapPanel = wrapPanel3;
                    break;
            }

            foreach (var child in currentWrapPanel.Children)
            {
                if (child is RadioButton radioButton && radioButton.IsChecked == true)
                {
                    return radioButton.Content.ToString();
                }
            }

            return string.Empty;
        }

        private void SaveResponsesToDatabase(string pergunta, string resposta)
        {
            string connectionString = "Data Source=DESKTOP-4C3EO3O;Initial Catalog=DB_PIM;User ID=sa;Password=joaomel123;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO QuestionarioRespostas (Pergunta, Resposta) VALUES (@Pergunta, @Resposta)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Pergunta", pergunta);
                    command.Parameters.AddWithValue("@Resposta", resposta);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ExibirResultadoTotalizado()
        {
            string connectionString = "Data Source=DESKTOP-4C3EO3O;Initial Catalog=DB_PIM;User ID=sa;Password=joaomel123;Encrypt=False;";

            int totalMuitoBoa = 0;
            int totalBoa = 0;
            int totalRuim = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Resposta, COUNT(*) AS Total FROM QuestionarioRespostas GROUP BY Resposta";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string resposta = reader["Resposta"].ToString();
                            int total = Convert.ToInt32(reader["Total"]);

                            if (resposta == "Muito Boa")
                                totalMuitoBoa = total;
                            else if (resposta == "Boa")
                                totalBoa = total;
                            else if (resposta == "Ruim")
                                totalRuim = total;
                        }
                    }
                }
            }

            // Preenche o gráfico com os valores totalizados
            resultadoChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Avaliações",
                    Values = new ChartValues<int> { totalMuitoBoa, totalBoa, totalRuim }
                }
            };

            // Exibe o gráfico
            resultadoChart.Visibility = Visibility.Visible;
        }
    }
}
