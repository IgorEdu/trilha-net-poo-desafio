namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get;}
        private string IMEI {get;}
        private int Memoria { get; }
        protected bool Ligado { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Ligado = false;
        }

        public void Ligar()
        {
            if(Ligado){
                Console.WriteLine("Smartphone já está ligado.");
                return;
            }

            Console.WriteLine("Ligando...");
            Ligado = true;
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}