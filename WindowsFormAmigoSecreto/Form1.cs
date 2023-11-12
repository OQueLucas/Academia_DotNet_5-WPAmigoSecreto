using System.Security.Cryptography.Xml;

namespace WindowsFormAmigoSecreto
{
    public partial class Form_Principal : Form
    {
        List<Pessoa> listPessoas = new();
        List<AmigoSecreto> listAmigosSecretos = new();
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void textBox_NomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Cadastrar();
            }
        }

        private void Button_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }

        private void GerarAmigoSecretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Persistencia.CSVReaderPessoas(listPessoas);

                Random rng = new();

                List<Pessoa> listAmigos = listPessoas.ToList();

                List<AmigoSecreto> listAmigosSecretos = new();

                foreach (Pessoa pessoa in listPessoas)
                {
                    int random = rng.Next(0, listAmigos.Count);
                    Pessoa amigo = listAmigos.ElementAt(random);

                    if (pessoa != amigo)
                    {
                        listAmigosSecretos.Add(new(pessoa, amigo));
                        listAmigos.Remove(amigo);
                    }
                    else
                    {
                        throw new Exception("Gere novamente, alguém tirou a si mesmo");
                    }
                }

                Persistencia.CSVWriterAmigo(listAmigosSecretos);

                MessageBox.Show("Lista gerada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void Cadastrar()
        {
            string[] vetor = textBox_NomeCompleto.Text.Split(" ");

            if (vetor.Length < 2)
            {
                MessageBox.Show("Insira ao menos nome e sobrenome!", "Nome incompleto");
                return;
            }

            string nome = textBox_NomeCompleto.Text;

            Pessoa p = new(nome);

            if (listPessoas.Contains(p))
            {
                MessageBox.Show("Essa pessoa já foi cadastrada!", "Já cadastrado");
                return;
            }

            listPessoas.Add(p);
            listPessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            Persistencia.CSVWriterPessoa(p);

            LoadListView();
            textBox_NomeCompleto.Text = "";
        }

        private void LoadListView()
        {
            listView_pessoas.Items.Clear();

            Persistencia.CSVReaderPessoas(listPessoas);

            listPessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (Pessoa p in listPessoas)
            {
                string[] items = { p.Nome, p.Email };

                listView_pessoas.Items.Add(new ListViewItem(items));
            }
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            LoadListView();
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
                ExcluirPessoa();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                panel_ExcluirPessoa.Visible = false;
            }
        }

        private void button_Excluir_Click(object sender, EventArgs e)
        {
            ExcluirPessoa();
        }

        public void ExcluirPessoa()
        {
            try
            {
                Persistencia.CSVRemovePessoa(listPessoas, textBox_ExcluirPessoa.Text);
                textBox_ExcluirPessoa.Text = "";
                LoadListView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }
        }

        private void exibirAmigoSecretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_AmigoSecreto.Items.Clear();
            panel_AmigoSecreto.Visible = true;

            Persistencia.CSVReaderAmigo(listAmigosSecretos);

            listAmigosSecretos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (AmigoSecreto amigoSecreto in listAmigosSecretos)
            {
                string[] items = { amigoSecreto.Nome, amigoSecreto.Email, amigoSecreto.NomeAmigo, amigoSecreto.EmailAmigo };

                listView_AmigoSecreto.Items.Add(new ListViewItem(items));
            }
        }

        private void button_SairAmigoSecreto_Click(object sender, EventArgs e)
        {
            panel_AmigoSecreto.Visible = false;
        }
    }
}
