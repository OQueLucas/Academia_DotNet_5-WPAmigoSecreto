using WindowsFormAmigoSecreto.Model;

namespace WindowsFormAmigoSecreto.ViewModel
{
    internal class AmigoSecretoViewModel
    {
        public List<Pessoa> ListPessoas;
        public List<AmigoSecreto> ListAmigosSecretos;
        public ListView ListView_amigosSecretos { get; set; }

        public AmigoSecretoViewModel(List<Pessoa> listPessoas)
        {
            ListPessoas = listPessoas;
        }

        public AmigoSecretoViewModel(List<AmigoSecreto> listAmigosSecretos)
        {
            ListAmigosSecretos = listAmigosSecretos;
        }

        public void Load()
        {
            ListView_amigosSecretos.Items.Clear();

            Persistencia.CSVReaderAmigo(ListAmigosSecretos);

            ListAmigosSecretos.Sort((a, b) => a.Nome.CompareTo(b.Nome));

            foreach (AmigoSecreto amigoSecreto in ListAmigosSecretos)
            {
                string[] items = { amigoSecreto.Nome, amigoSecreto.Email, amigoSecreto.NomeAmigo, amigoSecreto.EmailAmigo };

                ListView_amigosSecretos.Items.Add(new ListViewItem(items));
            }
        }

        public void GerarAmigoSecreto()
        {
            try
            {
                Persistencia.CSVReaderPessoas(ListPessoas);

                Random rng = new();

                List<Pessoa> listAmigos = ListPessoas.ToList();

                List<AmigoSecreto> listAmigosSecretos = new();

                foreach (Pessoa pessoa in ListPessoas)
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
    }
}
