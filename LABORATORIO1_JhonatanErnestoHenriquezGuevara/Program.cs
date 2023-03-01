using LABORATORIO1_JhonatanErnestoHenriquezGuevara.Entidades;
using LABORATORIO1_JhonatanErnestoHenriquezGuevara.Negocio;
using System;

namespace LABORATORIO1_JhonatanErnestoHenriquezGuevara
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            ClsPersona clspersona = new ClsPersona();
            Boolean execute = true;
            do
            {
                Console.WriteLine("Digita tu nombre");
                persona.Nombre = Console.ReadLine();

                Console.WriteLine("Digita tu edad");
                persona.Edad = int.Parse(Console.ReadLine());

                Boolean seguir = true;
                do
                {
                    Console.WriteLine("Digita tu sexo (H = Hombre / M = Mujer)");
                    try
                    {
                        persona.Sexo = char.Parse(Console.ReadLine());
                        seguir = false;
                    }
                    catch (Exception)
                    {
                        seguir = true;
                        Console.WriteLine("Algo salio mal");
                    }
                } while (seguir);
                
                Console.WriteLine("Digita tu peso en libras");
                persona.Peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digita tu altura");
                persona.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine(clspersona.calcularIMC(persona));
                Console.WriteLine(clspersona.esMayorDeEdad(persona));

                Console.WriteLine("\n¿Desea ingresar otro registro? (0 = NO / 1 = SI)");
                if (int.Parse(Console.ReadLine()) == 0) {
                    execute = false;
                }
                else
                {
                    Console.Clear();
                    execute = true;
                }




            } while (execute);

            

            
        }
    }
}
