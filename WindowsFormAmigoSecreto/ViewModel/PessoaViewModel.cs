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

            Persistencia.CSVReaderPessoas(ListPessoas);

            ListPessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (Pessoa p in ListPessoas)
            {
                string[] items = { p.Nome, p.Email };

                ListView_pessoas.Items.Add(new ListViewItem(items));
            }
        }

        public void Cadastrar()
        {
            Pessoa p;
            string[] vetor = TextBox_NomeCompleto.Text.Split(" ");

            if (vetor.Length < 2)
            {
                MessageBox.Show("Insira ao menos nome e sobrenome!", "Nome incompleto");
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
                return;
            }

            ListPessoas.Add(p);
            ListPessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            Persistencia.CSVWriterPessoa(p);

            Load();
            LimparCampos();
        }

        public void ExcluirPessoa()
        {
            try
            {
                Persistencia.CSVRemovePessoa(ListPessoas, TextBox_ExcluirPessoa.Text);
                Load();
                TextBox_ExcluirPessoa.Text = "";
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
        }
    }
}
