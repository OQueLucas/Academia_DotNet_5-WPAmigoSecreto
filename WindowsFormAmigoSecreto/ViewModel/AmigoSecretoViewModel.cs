using WindowsFormAmigoSecreto.Model;

namespace WindowsFormAmigoSecreto.ViewModel
{
    internal class AmigoSecretoViewModel
    {
        public ListView ListView_amigosSecretos { get; set; }

        public AmigoSecretoViewModel() { }

        public void Load(List<AmigoSecreto> listAmigosSecretos)
        {
            ListView_amigosSecretos.Items.Clear();

            Persistencia.CSVReaderAmigo(listAmigosSecretos);

            listAmigosSecretos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (AmigoSecreto amigoSecreto in listAmigosSecretos)
            {
                string[] items = { amigoSecreto.Nome, amigoSecreto.Email, amigoSecreto.NomeAmigo, amigoSecreto.EmailAmigo };

                ListView_amigosSecretos.Items.Add(new ListViewItem(items));
            }
        }

        public void GerarAmigoSecreto(List<Pessoa> listPessoas)
        {
                try
            {
                if (listPessoas.Count == 0)
                {
                    throw new Exception("Não há ninguém na lista, Carregue uma lista existente ou Cadastre novas pessoas!");
                }

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
        public void EspiarAmigoSecreto()
        {
            DialogResult abrir = MessageBox.Show("Deseja realmente abrir este arquivo?", "", MessageBoxButtons.OKCancel);
            if (abrir == DialogResult.Cancel)
            {
                return;
            }

            DialogResult estragar = MessageBox.Show("Você pode estragar a brincadeira", "", MessageBoxButtons.OKCancel);
            if (estragar == DialogResult.Cancel)
            {
                return;
            }

            DialogResult desistir = MessageBox.Show("Não vai desistir?", "", MessageBoxButtons.OKCancel);
            if (desistir == DialogResult.Cancel)
            {
                return;
            }

            DialogResult insiste = MessageBox.Show("Você é insistente", "", MessageBoxButtons.OKCancel);
            if (insiste == DialogResult.Cancel)
            {
                return;
            }

            FormAmigoSecreto formAmigoSecreto = new();
            formAmigoSecreto.ShowDialog();
        }
    }
}
