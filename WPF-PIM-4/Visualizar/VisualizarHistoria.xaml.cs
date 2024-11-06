using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace WPF_PIM_4.Visualizar
{
    public partial class VisualizarHistoria : UserControl
    {
        private List<string> historias;
        private List<string> titulos;
        private List<string> imagens; // Lista de imagens
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

            // Lista de títulos
            titulos = new List<string>
            {
                "Vida em Marte",
                "Exploração de Marte",
                "Phobos e Deimos",
                "Sistema Marte"
            };

            // Lista de imagens correspondentes às histórias
            imagens = new List<string>
            {
                "/Imagens/pedrasMarte.jpeg",
                "/Imagens/rbMarte.jpeg",
                "/Imagens/asteroideMarte.jpeg",
                "/Imagens/luaMarte.jpeg"
            };

            AtualizarConteudoRichTextBox();
        }

        private void AtualizarConteudoRichTextBox()
        {
            // Atualizando o conteúdo do RichTextBox
            rtbHistoria.Document.Blocks.Clear();
            rtbHistoria.Document.Blocks.Add(new Paragraph(new Run(historias[indiceAtual])));

            // Atualizando o título e a navegação
            titleTextBlock.Text = titulos[indiceAtual];
            textBlockTelaAtual.Text = $"{indiceAtual + 1}/{historias.Count}";

            // Carregar a imagem correspondente à história
            imgHistoria.Source = new BitmapImage(new Uri(imagens[indiceAtual], UriKind.Relative));
        }

        private void btnProximo_Click(object sender, RoutedEventArgs e)
        {
            if (indiceAtual < historias.Count - 1)
            {
                indiceAtual++;
                AtualizarConteudoRichTextBox();
            }
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (indiceAtual > 0)
            {
                indiceAtual--;
                AtualizarConteudoRichTextBox();
            }
        }
    }
}
