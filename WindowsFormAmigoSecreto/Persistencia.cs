using System.Text;
using WindowsFormAmigoSecreto.Model;

namespace WindowsFormAmigoSecreto
{
    internal class Persistencia
    {
        static readonly string pathPessoas = @"..\..\..\Data\pessoas.csv";
        static readonly string pathAmigoSecreto = @"..\..\..\Data\amigoSecreto.csv";

        public static void CSVReaderPessoas(List<Pessoa> pessoas)
        {
            StreamReader? streamReader = null;
            try
            {
                streamReader = new(pathPessoas, Encoding.UTF8);

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(";");
                    Pessoa pessoa = new(line[0], line[1]);
                    if (!pessoas.Contains(pessoa))
                    {
                        pessoas.Add(pessoa);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível abrir o arquivo.\n" + e.Message, e.GetType().Name);
            }
            finally
            {
                streamReader?.Close();
            }
        }

        public static void CSVWriterPessoa(Pessoa pessoa)
        {
            StreamWriter? streamWriter = null;
            try
            {
                streamWriter = File.Exists(pathPessoas) ? File.AppendText(pathPessoas) : File.CreateText(pathPessoas);
                streamWriter.WriteLine(pessoa);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }
            finally
            {
                streamWriter?.Close();
            }
        }

        public static void CSVWriterPessoa(List<Pessoa> listPessoas)
        {
            StreamWriter? streamWriter = null;
            try
            {
                streamWriter = File.CreateText(pathPessoas);
                foreach (Pessoa p in listPessoas)
                {
                    streamWriter.WriteLine(p);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }
            finally
            {
                streamWriter?.Close();
            }
        }

        public static void CSVReaderAmigo(List<AmigoSecreto> amigosSecretos)
        {
            StreamReader? streamReader = null;
            try
            {
                streamReader = new(pathAmigoSecreto, Encoding.UTF8);

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(";");
                    Pessoa pessoa = new(line[0], line[1]);
                    Pessoa amigo = new(line[2], line[3]);
                    AmigoSecreto amigoSecreto = new(pessoa, amigo);
                    if (!amigosSecretos.Contains(amigoSecreto))
                    {
                        amigosSecretos.Add(amigoSecreto);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível abrir o arquivo.\n" + e.Message, e.GetType().Name);
            }
            finally
            {
                streamReader?.Close();
            }
        }

        public static void CSVWriterAmigo(List<AmigoSecreto> listAmigosSecretos)
        {
            StreamWriter? streamWriter = null;
            try
            {
                streamWriter = File.CreateText(pathAmigoSecreto);
                foreach (AmigoSecreto amigoSecreto in listAmigosSecretos)
                {
                    streamWriter.WriteLine(amigoSecreto);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }
            finally
            {
                streamWriter?.Close();
            }
        }

        public static Pessoa CSVFindPessoa(List<Pessoa> listPessoas, string input)
        {
            Pessoa? pessoa;

            if (listPessoas.Count == 0)
            {
                throw new Exception("Não tem ninguém na lista!");
            }

            if (Util.EmailIsValid(input))
            {
                pessoa = listPessoas.FirstOrDefault(p => p.Email.ToUpper() == input.ToUpper());
            }
            else
            {
                pessoa = listPessoas.FirstOrDefault(p => p.Nome.ToUpper() == input.ToUpper());
            }

            if (pessoa == null)
            {
                throw new Exception("Pessoa não encontrada!");
            }

            return pessoa;
        }

        public static void CSVRemovePessoa(List<Pessoa> listPessoas, string input)
        {
            Pessoa pessoa = CSVFindPessoa(listPessoas, input);

            listPessoas.Remove(pessoa);

            CSVWriterPessoa(listPessoas);

            MessageBox.Show($"{pessoa.Nome} foi excluído(a) com sucesso!");
        }
    }
}
