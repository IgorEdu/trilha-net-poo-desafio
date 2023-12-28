namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        public override void InstalarAplicativo(string nomeApp){
            if(Ligado){
                Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Nokia");
            } else {
                Console.WriteLine("Nokia está desligao. Não pode instalar o aplicativo " + nomeApp);
            }
        }
    }
}