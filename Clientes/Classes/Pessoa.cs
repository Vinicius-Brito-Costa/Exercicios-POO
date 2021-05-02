namespace Clientes.Classes
{
    public class Pessoa
    {
        private string Nome;
        private string DataNascimento;
        public Pessoa(string nome, string data){
            SetNome(nome);
            SetDataNascimento(data);
        }
        public string GetNome(){
            return this.Nome;
        }
        public void SetNome(string nome){
            this.Nome = nome;
        }
        public string GetDataNascimento(){
            return this.DataNascimento;
        }
        public void SetDataNascimento(string data){
            this.DataNascimento = data;
        }
    }
}