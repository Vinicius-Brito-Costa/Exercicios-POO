namespace Clientes.Classes
{
    public class Cliente : Pessoa
    {
        private int Id;
        private TipoCliente Tipo;
        private int RG;

        public Cliente(string nome, string data, TipoCliente tipoConta, int rg) : base(nome, data){
            SetTipo(tipoConta);
            SetRG(rg);
        }
        public int GetId(){
            return this.Id;
        }
        public void SetId(int id){
            this.Id = id;
        }
        public TipoCliente GetTipo(){
            return this.Tipo;
        }
        public void SetTipo(TipoCliente tipo){
            this.Tipo = tipo;
        }
        public int GetRG(){
            return this.RG;
        }
        public void SetRG(int rg){
            this.RG = rg;
        }
        public override string ToString(){
            string data = $"Nome: {this.GetNome()}\n";
            data += $"Data: {this.GetDataNascimento()}\n";
            data += $"Tipo da conta: {this.GetTipo()}\n";
            data += $"RG: {this.GetRG()}";
            return data;
        }
    }
}