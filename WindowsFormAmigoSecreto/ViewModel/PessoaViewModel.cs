using WindowsFormAmigoSecreto.Model;

namespace WindowsFormAmigoSecreto.ViewModel
{
    internal class PessoaViewModel
    {
        List<Pessoa> ListPessoas;

        public ListView ListView_pessoas { get; set; }
        public TextBox TextBox_NomeCompleto { get; set; }
        public TextBox TextBox_Email { get; set; }
        public TextBox TextBox_ExcluirPessoa { get; set; }

        public PessoaViewModel(List<Pessoa> listPessoas)
        {
            ListPessoas = listPessoas;
        }

        public void Load()
        {
            ListView_pessoas.Items.Clear();

            ListPessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (Pessoa p in ListPessoas)
            {
                string[] items = { p.Nome, p.Email };

                ListView_pessoas.Items.Add(new ListViewItem(items));
            }

            TextBox_NomeCompleto.Focus();
        }

        public void Cadastrar()
        {
            Pessoa p;
            string[] vetor = TextBox_NomeCompleto.Text.Split(" ");

            if (vetor.Length < 2)
            {
                MessageBox.Show("Insira ao menos nome e sobrenome!", "Nome incompleto");
                TextBox_NomeCompleto.Focus();
                return;
            }

            string nome = TextBox_NomeCompleto.Text;
            string email = TextBox_Email.Text;

            if (email == "")
            {
                p = new(nome);
            }
            else
            {
                if (!Util.EmailIsValid(email))
                {
                    MessageBox.Show("Email não é válido");
                    return;
                }

                p = new(nome, email);
            }

            if (ListPessoas.Contains(p))
            {
                MessageBox.Show("Essa pessoa já foi cadastrada!", "Já cadastrado");
                TextBox_NomeCompleto.Focus();
                return;
            }

            ListPessoas.Add(p);
            ListPessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            Load();
            LimparCampos();
        }

        public void SalvarLista()
        {
            string path = @"F:\workspace";

            DialogResult result = FileLocation.ShowDialog(ref path, "Onde gostaria de salvar o arquivo pessoas.csv?", "Digite apenas o caminho!");

            if (result == DialogResult.OK) {
                Persistencia.CSVWriterPessoa(ListPessoas, path);
            }
        }

        public void PopularLista()
        {
            DialogResult result = MessageBox.Show("Deseja popular a lista?", "Bem vindo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CarregarLista();
            }
        }

        public void CarregarLista()
        {
            string path = @"F:\workspace";

            DialogResult result = FileLocation.ShowDialog(ref path, "De onde gostaria de carregar?", "Digite apenas o caminho!");

            if (result == DialogResult.OK)
            {
                Persistencia.CSVReaderPessoas(ListPessoas, path);
            }

            Load();
        }

        public void LimparLista()
        {
            ListPessoas = new List<Pessoa>();
            Load();
        }

        public void ExcluirPessoa()
        {
            try
            {
                if (ListPessoas.Count == 0)
                {
                    TextBox_NomeCompleto.Focus();
                    throw new Exception("Lista de pessoas vazias");
                }

                if (TextBox_Email.Text == "" && TextBox_NomeCompleto.Text == "")
                {
                    TextBox_NomeCompleto.Focus();
                    throw new Exception("Insira um email ou nome para ser excluído!");
                }

                bool removeu = false;
                Pessoa pessoa;

                pessoa = Persistencia.FindPessoa(ListPessoas, TextBox_Email.Text);

                if (pessoa == null)
                {
                    pessoa = Persistencia.FindPessoa(ListPessoas, TextBox_NomeCompleto.Text);
                }

                removeu = Persistencia.RemovePessoa(ListPessoas, pessoa);

                Load();
                LimparCampos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }
        }

        public void LimparCampos()
        {
            TextBox_NomeCompleto.Text = "";
            TextBox_Email.Text = "";
            TextBox_NomeCompleto.Focus();
        }
    }
}
