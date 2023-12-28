namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        public override void InstalarAplicativo(string nomeApp){
            if(Ligado){
                Console.WriteLine("Instalando o aplicativo " + nomeApp + " no iPhone");
            } else {
                Console.WriteLine("iPhone está desligao. Não pode instalar o aplicativo " + nomeApp);
            }
        }
    }
}