using WindowsFormAmigoSecreto.Model;
using WindowsFormAmigoSecreto.ViewModel;

namespace WindowsFormAmigoSecreto
{
    public partial class FormAmigoSecreto : Form
    {
        private AmigoSecretoViewModel _amigoSecreto;

        List<AmigoSecreto> listAmigosSecretos = new();

        public FormAmigoSecreto()
        {
            InitializeComponent();

            _amigoSecreto = new();
            _amigoSecreto.ListView_amigosSecretos = listView_AmigoSecreto;

            this.Load += delegate { _amigoSecreto.Load(listAmigosSecretos); };
        }
    }
}
