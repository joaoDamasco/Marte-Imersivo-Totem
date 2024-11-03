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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_PIM_4.Visualizar
{
    /// <summary>
    /// Interaction logic for VisualizarHistoria.xaml
    /// </summary>
    public partial class VisualizarHistoria : UserControl
    {

        private List<string> historias;
        private List<string> titulos;
        private int indiceAtual = 0;

        public VisualizarHistoria()
        {
            InitializeComponent();

            // Lista de histórias
            historias = new List<string>
    { "A existência de vida em Marte ainda \né uma questão em aberto\nMas há indícios que podem sugerir que o planeta já tenha abrigado \nvida ou que ainda a abrigue: Em agosto de 2024,\n a NASA anunciou a detecção de possíveis\n bioassinaturas em uma rocha\n marciana. A rocha contém matéria orgânica e pontos",

                "A primeira missão enviada pela Nasa,\n agência espacial norte-americana, \ndeu-se entre os anos de 1962 e 1973, e foi chamada de \n Mariner 3 & 4. Desde então,\n a Nasa contabiliza 22 missões ao Planeta Vermelho,\n com descobertas importantes.",

                "Marte possui duas pequenas luas, Phobos e Deimos,\n os seus satélites naturais. \nAmbas foram descobertas pelo astrônomo Asaph \n Hall, em 1877. Phobos é a maior delas,\n com diâmetro de 25 km. Deimos é a menor\n das luas de Marte, com 15 km de diâmetro,\n e também a mais distante",

                "Marte é um dos nove planetas do Sistema Solar.\n É o quarto a partir do Sol, \nestando localizado a uma distância de pouco mais de\n 227 milhões de quilômetros desse astro.\n O planeta Marte completa uma volta ao redor \ndo próprio eixo em 24 horas e 37 minutos,\n ao passo que o movimento de translação demora"
            };


            titulos = new List<string>
    {
        "Vida em Marte",
        "Exploração de Marte",
        "Phobos e Deimos",
        "Sistema Marte"
    };

           
            AtualizarConteudoRichTextBox();
        }

        private void AtualizarConteudoRichTextBox()
        {
           
            rtbHistoria.Document.Blocks.Clear();
            rtbHistoria.Document.Blocks.Add(new Paragraph(new Run(historias[indiceAtual])));

           
            titleTextBlock.Text = titulos[indiceAtual];
            textBlockTelaAtual.Text = $"{indiceAtual + 1}/{historias.Count}";
        }

        private void btnProximo_Click(object sender, RoutedEventArgs e)
        {
            // Botão Próximo
            if (indiceAtual < historias.Count - 1)
            {
                indiceAtual++;
                AtualizarConteudoRichTextBox();
            }
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            // Botão Anterior
            if (indiceAtual > 0)
            {
                indiceAtual--;
                AtualizarConteudoRichTextBox();
            }
        }

    }
}
