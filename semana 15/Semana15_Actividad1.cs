using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Pipes;

public class Estudiante 
{
    public string Nombre;
    public int Edad;
    public string Carrera;
    public string Carnet; 
    public int NotaDeAdmision; 
    public Estudiante (string Nombre, int Edad, string Carrera, string Carnet, int NotaDeAdmision)
    {
        this.Nombre = Nombre;
        this.Edad = Edad;
        this.Carrera = Carrera;
        this.Carnet = Carnet;
        this.NotaDeAdmision = NotaDeAdmision;

    }
    public static void MostrarResumen(string Nombre, int Edad, string Carrera, string Carnet, int NotaDeAdmision)
    {
        Console.WriteLine($"Nombre: {Nombre} \n Edad: {Edad} \n Carrera: {Carrera} \n Carnet: {Carnet} \n Nota de Admision: {NotaDeAdmision} ");
    }
    public static bool PuedeMatricular(int NotaDeAdmision, string Carnet)
    {
        bool matricular;
        if (NotaDeAdmision > 75)
        {
            
            matricular = true;
            bool terminaCon = Carnet.EndsWith("25");
            if (terminaCon)
            {
                Console. WriteLine($"Haz aprobado el examen de admision");
                return true;
            }
            else 
            {
                Console. WriteLine($"tu carnet no es valido");
                return false;
            }
        }
        else 
        {
            Console. WriteLine($"Haz perdido el examen de admision");
            matricular = false;
        }
        return matricular;
       

    }


}
class claseSemana15
{
    static void Main(string[] args)
    {
        string nombreIngresado;
        string edadIngresadaTexto;
        int edadIngresadaNumero;
        string carreraIngresada; 
        string carnet;
        string NotaDeAdmisionIngresadaTexto;
        int NotaDeAdmisionIngresadaNumero;
        
        Console.WriteLine($"ingresa tu nombre");
        nombreIngresado = Console.ReadLine();

        while (string.IsNullOrEmpty(nombreIngresado) || string.IsNullOrWhiteSpace(nombreIngresado))
        {
            Console.WriteLine($"ingresa tu nombre nuevamente, ingresa un dato valido");
            nombreIngresado = Console.ReadLine();
            break;
        }
        
        while (true)
        {
            Console.WriteLine($"ingresa tu edad");
            edadIngresadaTexto = Console.ReadLine();

            if (int.TryParse(edadIngresadaTexto, out edadIngresadaNumero ) && edadIngresadaNumero > 0 && edadIngresadaNumero < 115 ) 
            {
                break; 
            }
            else 
            {
                Console.WriteLine($"ingrese un número valido");
            }
        }
        Console.WriteLine($"ingresa tu carrera");
         carreraIngresada = Console.ReadLine();

        while (string.IsNullOrEmpty(carreraIngresada) || string.IsNullOrWhiteSpace(carreraIngresada))
        {
            Console.WriteLine($"ingresa tu carrera nuevamente, ingresa un dato valido");
            carreraIngresada = Console.ReadLine();
            break;
        }
       Console.WriteLine($"ingresa tu carnet");
        carnet = Console.ReadLine();

        while (string.IsNullOrEmpty(carnet) || string.IsNullOrWhiteSpace(carnet))
        {
            Console.WriteLine($"ingresa tu carnet nuevamente, ingresa un dato valido");
            nombreIngresado = Console.ReadLine();
            break;
        }
            while (true)
        {
            Console.WriteLine($"ingresa tu nota de examen de admision");
            NotaDeAdmisionIngresadaTexto = Console.ReadLine();

            if (int.TryParse(NotaDeAdmisionIngresadaTexto, out NotaDeAdmisionIngresadaNumero ) && NotaDeAdmisionIngresadaNumero >= 0 && NotaDeAdmisionIngresadaNumero <= 100 ) 
            {
                break; 
            }
            else 
            {
                Console.WriteLine($"ingrese un número valido");
            }
        }
        
        Estudiante Estudiante = new Estudiante(nombreIngresado, edadIngresadaNumero, carreraIngresada, carnet, NotaDeAdmisionIngresadaNumero); 

        Estudiante.MostrarResumen(nombreIngresado, edadIngresadaNumero, carreraIngresada, carnet, NotaDeAdmisionIngresadaNumero);
        Estudiante.PuedeMatricular(NotaDeAdmisionIngresadaNumero, carnet); 


    }
}