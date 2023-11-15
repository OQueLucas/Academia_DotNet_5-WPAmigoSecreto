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
            };

            _amigoSecreto = new();

            // Inicio
            button_CadastrarPessoa.Click += delegate { _pessoa.Cadastrar(); };
            button_LimparCampos.Click += delegate { _pessoa.LimparCampos(); };
            button_ExcluirPessoa.Click += delegate { _pessoa.ExcluirPessoa(); };

            // Rodapé
            button_CarregarLista.Click += delegate { _pessoa.CarregarLista(); };
            button_LimparLista.Click += delegate { _pessoa.LimparLista(); };
            button_SalvarLista.Click += delegate { _pessoa.SalvarLista(); };

            // Barra Lateral AmigoSecreto
            button_GerarPares.Click += delegate { _amigoSecreto.GerarAmigoSecreto(listPessoas); };
            button_FormAmigoSecreto.Click += delegate
            {
                MessageBox.Show("Deseja realmente abrir este arquivo?");
                MessageBox.Show("Você pode estragar a brincadeira");
                FormAmigoSecreto formAmigoSecreto = new();
                formAmigoSecreto.Show();
            };
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
    }
}
