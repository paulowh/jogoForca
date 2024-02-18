using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            string conexaoString = "server=localhost;user=root;database=db_jogoForca;port=3306;password=";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string scriptSQL = "SELECT id, palavra FROM tb_palavras";


                using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))
                {
                    conexao.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            int id = reader.GetInt32(0);// Obtém o valor do primeiro campo (ID) como um inteiro.
                            string palavra = reader.GetString(1);// Obtém o valor do segundo campo (palavra) como uma string.
                            
                            ListViewItem lista = new ListViewItem(id.ToString() + " - " + palavra);// Cria um novo item do ListView com o ID e a palavra concatenados.
                            listViewCadastro.Items.Add(lista);// Adiciona o novo item ao ListViewCadastro.
                        }
                    }

                    conexao.Close();
                }
            }
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            
            listViewCadastro.View = View.Details;// Define a visualização do ListView como "Details", que exibirá os itens em formato de TABELA
            listViewCadastro.Columns.Add("palavras", 255);// Adiciona uma coluna ao ListViewCadastro com o título "palavras" e largura de 255 pixels.

            CarregarDados();// Chama a função CarregarDados para carregar os dados no ListViewCadastro.
        }

        private void CadastrarDados(string palavra)
        {
            string conexaoString = "server=localhost;user=root;database=db_jogoForca;port=3306;password=";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUES (@valorPalavra)";// Define o script de INSERT do banco de dados

                    using (MySqlCommand command = new MySqlCommand(scriptSQL, conexao))
                    {
                        conexao.Open();

                        command.Parameters.AddWithValue("@valorPalavra", palavra);// Adiciona o parâmetro da informação ao comando SQL para evitar SQL Injection.

                        int linhasAfetadas = command.ExecuteNonQuery();// Executa o comando SQL para inserir a informação no banco de dados.

                        if (linhasAfetadas > 0)// Verifica se pelo menos uma linha foi afetada (ou seja, a inserção foi bem-sucedida).
                        {
                            MessageBox.Show("Palavra Cadastrada com sucesso !!!");
                        }

                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Se ocorrer uma exceção durante o processo, exibe o erro na tela.
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string palavraEscolhida = txbCadastro.Text;

            if (palavraEscolhida.Trim() != "")
            {
                CadastrarDados(palavraEscolhida);
                
            }

            txbCadastro.Text = "";
            listViewCadastro.Items.Clear();
            CarregarDados();
        }
    }
}
