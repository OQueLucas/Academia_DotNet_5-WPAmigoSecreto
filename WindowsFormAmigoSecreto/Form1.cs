using WindowsFormAmigoSecreto.Model;
using WindowsFormAmigoSecreto.ViewModel;

namespace WindowsFormAmigoSecreto
{
    public partial class Form_Principal : Form
    {
        private PessoaViewModel _pessoa;
        private AmigoSecretoViewModel _amigoSecreto;
        List<Pessoa> listPessoas = new();
        public Form_Principal()
        {
            InitializeComponent();

            _pessoa = new(listPessoas)
            {
                ListView_pessoas = listView_pessoas,
                TextBox_NomeCompleto = textBox_NomeCompleto,
                TextBox_Email = textBox_Email,
                TextBox_ExcluirPessoa = textBox_ExcluirPessoa,
            };

            this.Load += delegate { _pessoa.Load(); };
            button_cadastrar.Click += delegate { _pessoa.Cadastrar(); };
            button_Excluir.Click += delegate { _pessoa.ExcluirPessoa(); };
            button_limpar.Click += delegate { _pessoa.LimparCampos(); };

            _amigoSecreto = new(listPessoas);

            GerarAmigoSecretoToolStripMenuItem.Click += delegate { _amigoSecreto.GerarAmigoSecreto(); };
        }

        private void textBox_NomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                _pessoa.Cadastrar();
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                _pessoa.Cadastrar();
            }

        }

        private void excluirPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_ExcluirPessoa.Visible = true;
            textBox_ExcluirPessoa.Focus();
        }

        private void button_Sair_Click(object sender, EventArgs e)
        {
            panel_ExcluirPessoa.Visible = false;
        }

        private void textBox_ExcluirPessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                _pessoa.ExcluirPessoa();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                panel_ExcluirPessoa.Visible = false;
            }
        }

        private void formAmigoSecretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAmigoSecreto formAmigoSecreto = new();
            formAmigoSecreto.Show();
        }
    }
}
