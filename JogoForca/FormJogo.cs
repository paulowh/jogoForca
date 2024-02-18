using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }

        string letrasTentadas = "";
        string palavra_secreta = "";

        //private string SortearPalavra()
        //{
        //    // Lista de palavras
        //    List<string> palavras = new List<string> { "csharp", "python", "ruby", "php", "javascript" };

        //    Random rnd = new Random();
        //    int indiceSorteado = rnd.Next(0, palavras.Count);

        //    // Recuperar a palavra correspondente ao índice sorteado
        //    string palavraSorteada = palavras[indiceSorteado];

        //    return palavraSorteada;
        //}

        private string SortearPalavra()
        {
            // Define a string de conexão com o banco de dados MySQL, incluindo o servidor, usuário, banco de dados e porta.
            string conexaoString = "server=localhost;user=root;database=db_jogoForca;port=3306;password=";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))// Estabelece uma conexão com o banco de dados MySQL usando a classe MySqlConnection.
            {
                string scriptSQL = "SELECT palavra FROM tb_palavras";// Define a consulta SQL para selecionar todas as palavras da tabela 'tb_palavras'.

                using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))// Cria um comando MySQL com a consulta SQL e a conexão estabelecida.
                {
                    conexao.Open();// Abre a conexão com o banco de dados.
                    List<string> palavrasBanco = new List<string>();// Cria uma lista para armazenar as palavras recuperadas do banco de dados.
                    using (MySqlDataReader reader = command.ExecuteReader())// Executa o comando SQL para recuperar os dados do banco de dados.
                    {
                        while (reader.Read())// Itera sobre cada registro retornado pela consulta.
                        {
                            // Obtém o valor da coluna 'palavra' e adiciona à lista de palavras.
                            string palavra = reader.GetString(0);
                            palavrasBanco.Add(palavra);
                        }
                    }

                    conexao.Close(); // Fecha a conexão com o banco de dados após recuperar todas as palavras.

                    Random rnd = new Random();
                    int indiceSorteado = rnd.Next(0, palavrasBanco.Count);

                    return palavrasBanco[indiceSorteado];
                }
            }
        }

        private char[] SepararLetraPalavra(string palavra)
        {
            //criando um array do tamanho da palavra que foi sorteada
            char[] letrasPalavra = new char[palavra.Length];

            letrasPalavra = palavra.ToCharArray();

            return letrasPalavra;
        }

        private string VerificarPalavra(char[] palavra, char[] letraTentadas)
        {
            string palavra_escondida = "";

            //laço de pepetição para 'esconder' a palavra
            for (int i = 0; i < palavra.Length; i++)
            {
                bool letraAcertada = false;
                for (int j = 0; j < letraTentadas.Length; j++)
                {
                    if (palavra[i] == letraTentadas[j])
                    {
                        palavra_escondida += palavra[i];
                        letraAcertada = true;
                    }
                }

                if (!letraAcertada)
                {
                    palavra_escondida += " _";
                }
            }
            return palavra_escondida;

        }

        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {


            string letra = txbTentativa.Text.ToLower();


            bool letraRepetida = false;
            for (int i = 0; i < letrasTentadas.Length; i++)
            {
                letraRepetida = false;
                if (letrasTentadas[i].ToString() == letra)
                {
                    MessageBox.Show("essa letra já foi jogada, tente novamente!!!");
                    letraRepetida = true;
                }
            }

            int verificarSeGanhou = 0;

            if (!letraRepetida)
            {
                letrasTentadas += letra;
                char[] letrasDaPalavra = SepararLetraPalavra(palavra_secreta);
                string palavra_exibicao = VerificarPalavra(letrasDaPalavra, letrasTentadas.ToCharArray());

                lbPalavraSecreta.Text = palavra_exibicao;

                verificarSeGanhou = 0;
                for (int i = 0; i < palavra_exibicao.Length; i++)
                {

                    if (palavra_exibicao[i] == '_')
                    {
                        verificarSeGanhou++;
                    }

                }
            }

            if (verificarSeGanhou == 0)
            {
                MessageBox.Show("Você ganhou!!!");
                this.Close();
            }

            txbTentativa.Text = "";

        }


        private void FormJogo_Load(object sender, EventArgs e)
        {
            palavra_secreta = SortearPalavra();
            lbPalavraSecreta.Text = VerificarPalavra(palavra_secreta.ToCharArray(), letrasTentadas.ToCharArray());
        }
    }
}
