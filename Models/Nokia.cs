namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // *IMPLEMENTADO !!!*
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        {

        }
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // *IMPLEMENTADO !!!*
         public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }

}