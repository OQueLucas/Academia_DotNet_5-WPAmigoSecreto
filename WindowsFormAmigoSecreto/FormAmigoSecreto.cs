namespace WindowsFormAmigoSecreto
{
    public partial class FormAmigoSecreto : Form
    {
        private AmigoSecretoViewModel _amigoSecreto;
        List<AmigoSecreto> listAmigosSecretos = new();

        public FormAmigoSecreto()
        {
            InitializeComponent();

            _amigoSecreto = new(listAmigosSecretos);

            this.Load += delegate { _amigoSecreto.Load(); };
        }
    }
}
