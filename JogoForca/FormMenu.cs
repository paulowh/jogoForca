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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Form formJogo = new FormJogo(); //criando uma instancia do nosso formulario
            formJogo.ShowDialog(); //pedindo para abrir o formualario
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form formCadastro = new FormCadastro(); //criando uma instancia do nosso formulario
            formCadastro.ShowDialog(); //pedindo para abrir o formualario
        }
    }
}
