using WindowsFormAmigoSecreto.Model;
using WindowsFormAmigoSecreto.ViewModel;

namespace WindowsFormAmigoSecreto
{
    public partial class FormAmigoSecreto : Form
    {
        private ViewModel.AmigoSecretoViewModel _amigoSecreto;
        List<Model.AmigoSecreto> listAmigosSecretos = new();

        public FormAmigoSecreto()
        {
            InitializeComponent();

            _amigoSecreto = new(listAmigosSecretos);
            _amigoSecreto.ListView_amigosSecretos = listView_AmigoSecreto;

            this.Load += delegate { _amigoSecreto.Load(); };
        }
    }
}
