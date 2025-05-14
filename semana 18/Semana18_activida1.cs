<<<<<<< HEAD
﻿using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Actividad1

{
    class Alumno
    {
        private const double NotaAprobatoria = 65.00;
        private string _nombreEstudiante;
        private string[] _nombresEstudiantes = new string[10];
        private int _numeroEstudiante;
        private double[,] _notasEstudiante = new double[10, 10];
        private int _fila;
        private int _clasesPerdidas;
        private double[] _notasNoAprobadas;
        private int _clasesGanadas;
        private double[] _notasAprobadas;
        private double _promedioClase;
        public double PromedioClase
        {
            get{return _promedioClase;}
            set{_promedioClase = value;}
        }
        public int ClasesPerdidas
        {
            get{return _clasesPerdidas;}
            set{_clasesPerdidas = value;}
        }
        public double[] NotasNoAprobadas
        {
            get{return _notasNoAprobadas;}
            set{_notasNoAprobadas = value;}

        }
        public int ClasesGanadas
        {
            get{return _clasesGanadas;}
            set{_clasesGanadas = value;}
        }
        public double[] NotasAprobadas
        {
            get{return _notasAprobadas;}
            set{_notasAprobadas = value;}
        }

        public int Fila
        {
            get
            {
                return _fila;
            }
            set
            {
                _fila = value;
            }
        }

        public string NombreEstudiante
        {
            get 
            {
                return _nombreEstudiante;

            }
            set
            {
                _nombreEstudiante = value;
            }
        }
        public int NumeroEstudiante
        {
            get 
            {
                return _numeroEstudiante;
            }
            set 
            {
                _numeroEstudiante = value;
            }
        }
        public string[] NombresEstudiantes 
        {
            get 
            {
                return _nombresEstudiantes; 
            }
            set 
            { 
             _nombresEstudiantes = value;
            }


        }
        public double[,] NotaEstudiante
        {
            get  
            {
                return _notasEstudiante;
            }
            set
            {
                _notasEstudiante = value;
            }
        }

        public void verificarString()
        {
            while(true)
            {
                if(!string.IsNullOrEmpty(NombreEstudiante) && !string.IsNullOrWhiteSpace(NombreEstudiante) && NombreEstudiante.All(char.IsLetter))
                {
                    break;
                    
                }
                else
                {
                    Console.WriteLine($"Ingrese un dato correcto");
                    NombreEstudiante = Console.ReadLine();
                }
            }
        }
        public void VerificarDouble()
        {
            while(true)
            {
                if (double.TryParse(Console.ReadLine(), out NotaEstudiante[Fila, NumeroEstudiante]) && (NotaEstudiante[Fila, NumeroEstudiante] > -1 && NotaEstudiante[Fila, NumeroEstudiante] < 101))
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Ingrese los datos nuevamente Ej.(15.20, entre 0 y 100)");
                }
            }
        }
        public void PedirNotas()
        {
            for (NumeroEstudiante = 0; NumeroEstudiante < 10; NumeroEstudiante++ )
            {
                Console.WriteLine($"Ingrese el nombre del estudiante");
                NombreEstudiante = Console.ReadLine();
                verificarString();
                
                NombreEstudiante = NombresEstudiantes [NumeroEstudiante];
                for (Fila = 0; Fila < 10; Fila ++)
                {
                    Console.WriteLine($"Ingrese la nota {Fila + 1} del estudiante {NombresEstudiantes[NumeroEstudiante]} número {NumeroEstudiante + 1}");
                    VerificarDouble();

                    
                }
            }
        }
        
        public void CalcularPromedio()
        {
            for(NumeroEstudiante = 0; NumeroEstudiante < 10; NumeroEstudiante++)
            {
                for (Fila = 0; Fila < 10; Fila ++)
                {
                    PromedioClase ++;   
                }
            }
            PromedioClase = PromedioClase / NumeroEstudiante;
            Console.WriteLine($"El promedio de la clase de ingenieria en sistemas es: {PromedioClase} Pts");

        
        }
        public void CalcularClasesPerdidas()
        {
            ClasesPerdidas = 0;
            NotasNoAprobadas = new double[ClasesPerdidas];
            for(NumeroEstudiante = 0; NumeroEstudiante < 10; NumeroEstudiante++)
            {
                for (Fila = 0; Fila < 10; Fila ++)
                {
                    
                    if(NotaEstudiante[Fila, NumeroEstudiante] < NotaAprobatoria)
                    {
                        ClasesPerdidas ++;
                        NotasNoAprobadas = new double[ClasesPerdidas];
                        NotaEstudiante[Fila, NumeroEstudiante] = NotasNoAprobadas[NumeroEstudiante];
                    }
                }
                Console.WriteLine($"Estudiante {NombresEstudiantes[NumeroEstudiante]}");
                
                foreach (int nota in NotasNoAprobadas)
                {
                    Console.Write($"Notas no aprobadas: {nota} \t");
                }
            }

        }
                public void CalcularClaseGanadas()
        {
            ClasesGanadas =  0;
            for(NumeroEstudiante = 0; NumeroEstudiante < 10; NumeroEstudiante++)
            {
                for (Fila = 0; Fila < 10; Fila ++)
                {
                    
                    if(NotaEstudiante[Fila, NumeroEstudiante] < NotaAprobatoria)
                    {
                        ClasesGanadas ++;
                        NotasAprobadas = new double[ClasesGanadas]
                        NotaEstudiante[Fila,NumeroEstudiante] = NotasAprobadas[NumeroEstudiante];
                    }
                }
                Console.WriteLine($"Estudiante: {NombresEstudiantes[NumeroEstudiante]}");
            
                foreach (int nota in NotasAprobadas)
                {
                    Console.Write($"Notas aprobadas: {nota} \t");
                }
            }

        }
        public void MostrarMenu()
        {
            int Opcion;
            do
            {
                Console.WriteLine("Que desea hacer? \n 1.)Mostrar nombre y notas aprobadas para cada alumno. \n2) Mostrar nombre y notas no aprobadas para cada alumno. \n 3) Mostrar el promedio de notas del grupo. \n 4) Salir del programa ");
                while(true)
                {
                    if (int.TryParse(Console.ReadLine(), out Opcion) && Opcion > 0 && Opcion< 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Ingrese una opcion valida");
                    }
                }
                switch(Opcion)
                {
                    case 1:
                        CalcularClaseGanadas();
                    break;
                    case 2:
                        CalcularClasesPerdidas();
                    break;
                    case 3:
                        CalcularPromedio();
                    break;
                }            
            }
            while (Opcion > 0 && Opcion < 4);
        }

    }
    class Semana18
    {
        static void Main()
        {
            Alumno alumno= new Alumno();
            
            alumno.PedirNotas();
            alumno.MostrarMenu();
            
        }
=======
﻿using System;
public class Program
{
    int numero;
    string cadena;
    public static void Main()
    {
        Program objetoProgram = new Program(3, "hola");
        objetoProgram.show();
    }
    Program(int numero, string cadena)
    {
        this.numero = numero;
        this.cadena = cadena;
    }
    void show()
    {
        Console.WriteLine(this.numero);
        Console.WriteLine(this.cadena);
>>>>>>> 207148bd3a38867e08e403eed13befed8bb1523d
    }
}