using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe vehicle1 = new Cotxe("Corolla", "Opel", 2020, 240.0, 2);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe vehicle2 = new Cotxe("Aygo", "Opel", 1990, 230.0, 4);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();
    }
}
