using Guanabara.Enums;
using System;
namespace Guanabara.Classes
{
    public class ContaBanco
    {
        public int NumeroConta;
        protected TipoConta TipoConta;
        private string DonoConta;
        private float Saldo;
        private bool StatusConta;

        public ContaBanco(int numeroConta, TipoConta tipoConta, string donoConta)
        {
            setDonoConta(donoConta);
            setSaldo(0);
            setStatusConta(false);
        }
        public void abrirConta(int numeroConta)
        {
            setNumeroConta(numeroConta);
            setTipoConta(getTipoConta());
            setDonoConta(getDonoConta());
            
            setStatusConta(true);
            if(this.TipoConta == TipoConta.ContaCorrente){
                setSaldo(50);
                Console.WriteLine("Conta corrente aberta com sucesso.");
            }
            else if(this.TipoConta == TipoConta.ContaPoupanca){
                setSaldo(150);
                Console.WriteLine("Conta poupança aberta com sucesso.");
            }
            else{
                Console.WriteLine("Erro ao abrir conta.");
            }
        }
        public void fecharConta(){
            if(this.Saldo > 0){
                Console.WriteLine("Conta com dinheiro");
            }
            else if(this.Saldo < 0){
                Console.WriteLine("Conta com débito");
            }
            else{
                setStatusConta(false);
                Console.WriteLine("Conta fechada com sucesso.");
            }
        }
        public void Depositar(float valor){
            if(this.StatusConta == true){
                setSaldo(getSaldo() + valor);
            }
            else{
                Console.WriteLine("Impossivel depositar, conta desativada.");
            }
        }
        public void Sacar(float valor){
            if(this.StatusConta == true){
                if(this.Saldo >= valor){
                    setSaldo(getSaldo() - valor);
                }
                else{
                    Console.WriteLine("Saldo insuficiente");
                }
            }
            else{
                Console.WriteLine("Impossivel sacar, conta desativada.");
            }
        }
        public void PagarMensalidade(){
            if(this.StatusConta == true){
                float valor = 0;
                if(getTipoConta() == TipoConta.ContaCorrente){
                    valor = 12;
                }
                else if( getTipoConta() == TipoConta.ContaPoupanca){
                    valor = 20;
                }
                Sacar(valor);
            }
            else{
                Console.WriteLine("Impossivel pagar.");
            }
        }
        public void setNumeroConta(int numeroConta)
        {
            this.NumeroConta = numeroConta;
        }
        public int getNumeroConta(){
            return this.NumeroConta;
        }
        public void setTipoConta(TipoConta tipoConta)
        {
            this.TipoConta = tipoConta;
        }
        public TipoConta getTipoConta(){
            return this.TipoConta;
        }
        public void setDonoConta(string donoConta)
        {
            this.DonoConta = donoConta;
        }
        public string getDonoConta(){
            return this.DonoConta;
        }
        public void setSaldo(float saldo)
        {
            this.Saldo = saldo;
        }
        public float getSaldo(){
            return this.Saldo;
        }
        public void setStatusConta(bool statusConta)
        {
            this.StatusConta = statusConta;
        }
        public bool getStatusConta(){
            return this.StatusConta;
        }
        public override string ToString(){
            string Info = "----------------Conta----------------";
            Info += $"\nNome: {getDonoConta()}";
            Info += $"\nStatus da conta: {(getStatusConta() ? "Ativo" : "Inativo")}";
            Info += $"\nTipo: {getTipoConta()}";
            Info += $"\nNumero da conta: {getNumeroConta()}";
            Info += $"\nSaldo: {getSaldo()}";
            Info += $"\n-------------------------------------";
            return Info;
        }
    }
}