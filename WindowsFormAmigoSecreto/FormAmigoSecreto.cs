namespace WindowsFormAmigoSecreto
{
    public partial class FormAmigoSecreto : Form
    {
        List<AmigoSecreto> listAmigosSecretos = new();
        public FormAmigoSecreto()
        {
            InitializeComponent();
        }

        private void FormAmigoSecreto_Load(object sender, EventArgs e)
        {
            listView_AmigoSecreto.Items.Clear();

            Persistencia.CSVReaderAmigo(listAmigosSecretos);

            listAmigosSecretos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (AmigoSecreto amigoSecreto in listAmigosSecretos)
            {
                string[] items = { amigoSecreto.Nome, amigoSecreto.Email, amigoSecreto.NomeAmigo, amigoSecreto.EmailAmigo };

                listView_AmigoSecreto.Items.Add(new ListViewItem(items));
            }
        }
    }
}
