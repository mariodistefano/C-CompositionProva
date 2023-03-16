using System;

namespace C_proveChiareComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creazione paese
            //Paese italia = new Paese("italia");
            Continente europa = new Continente("europa");
            Continente.createPaese("italia");



            // uso il metodo createRegione del paese per creare la regione
            italia.createRegione("sicilia");

            
        }
    }
}
