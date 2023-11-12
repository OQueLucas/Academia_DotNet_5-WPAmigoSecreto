using System.Text;
using System;
using System.IO;

namespace WindowsFormAmigoSecreto
{
    internal class Persistencia
    {
        static readonly string pathPessoas = @"..\..\..\Data\pessoas.csv";
        static readonly string tempFile = @"..\..\..\Data\pessoastemp.csv";
        static readonly string pathAmigoSecreto = @"..\..\..\Data\amigoSecreto.csv";

        public static void CSVReaderPessoas(List<Pessoa> pessoas)
        {
            StreamReader? streamReader = null;
            try
            {
                streamReader = new(pathPessoas, Encoding.UTF8);

                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine().Split(";");
                    Pessoa pessoa = new(line[0], line[1]);
                    if (!pessoas.Contains(pessoa))
                    {
                        pessoas.Add(pessoa);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível abrir o arquivo. " + e.Message, e.GetType().Name);
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

        public static void CSVRemovePessoa(string nome)
        {
            try
            {
                List<Pessoa> pessoas = new();
                CSVReaderPessoas(pessoas);

                if (pessoas.Count == 0)
                {
                    MessageBox.Show("Não tem ninguém na lista!");
                    return;
                }
                Pessoa pessoa = pessoas.FirstOrDefault(p => p.Nome == nome);

                if (pessoa == null)
                {
                    MessageBox.Show($"{nome} não encontrada!");
                    return;
                }
                else
                {
                    MessageBox.Show($"{nome} foi excluído com sucesso!");
                }
                pessoas.Remove(pessoa);

                CSVWriterPessoa(pessoas);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não é possível excluir a pessoa. " + e.Message, e.GetType().Name);
            }
        }
    }
}
