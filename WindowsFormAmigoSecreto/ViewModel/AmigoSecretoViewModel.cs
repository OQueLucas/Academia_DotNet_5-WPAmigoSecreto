using WindowsFormAmigoSecreto.Model;

namespace WindowsFormAmigoSecreto.ViewModel
{
    internal class AmigoSecretoViewModel
    {
        public ListView ListView_amigosSecretos { get; set; }

        public AmigoSecretoViewModel(){}

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
    }
}
