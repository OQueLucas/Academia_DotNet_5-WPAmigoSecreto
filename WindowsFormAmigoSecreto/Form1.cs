namespace WindowsFormAmigoSecreto
{
    public partial class Form_Principal : Form
    {
        List<Pessoa> pessoas = new();
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

        private void ColocarListaTextBox()
        {
            listView_pessoas.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                string[] items = { p.Nome, p.Email };

                listView_pessoas.Items.Add(new ListViewItem(items));
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

            if (pessoas.Contains(p))
            {
                return;
            }

            pessoas.Add(p);
            pessoas.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            ColocarListaTextBox();
            textBox_NomeCompleto.Text = "";
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
