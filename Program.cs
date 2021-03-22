using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class Program
    {
     

    class persona
    {
            private int cedula;
            private String nombre;
            private String apellido;
            private int edad;

            public persona()
            {
                cedula = 0011010453;
                nombre = "juan";
                apellido = "perez";
                edad = 16;
            }

         
            public String responsabilidad(){

               return "\nLa informacion de la persona es:\n "+ cedula + nombre + apellido + edad;
            
            }

        }

       class profesor : persona{

            public profesor()
            {
                sueldo = 50000;
                
            }


            private int sueldo;           
           
            public String getsueldo()
            {
              return "\nEl sueldo del profesor es\n"+ sueldo;
            }
        }

        class Contacto
        {
            private String nombre;
            private String apellidos;
            private int telefono;
            private String direccion;

            public void SetContacto()
            {
                Console.WriteLine("ingresa tu nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingresa tu apellidos");
                apellidos = Console.ReadLine();
                Console.WriteLine("ingresa tu numero telefono");
                telefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa tu direccion");
                direccion = Console.ReadLine();
            }

            public void Saludar()
            {
                Console.WriteLine("Hola, Soy " + nombre +" "+ apellidos + ", Mi telefono es: "+ telefono +" y mi direccion es:\n "+ direccion);

            }
        }

        class ProbarContacto: Contacto
        {
            static void Main(string[] args)
            {
                /*persona a = new persona();
                Console.WriteLine(a.responsabilidad());
                profesor b = new profesor();
                Console.WriteLine(b.getsueldo());
                Console.ReadLine();
             
                */
                /*  Contacto c1 = new Contacto();
                  Contacto c2 = new Contacto();
                  Console.Write("Datos del COntacto 1\n");
                  c1.SetContacto();
                  c1.Saludar();
                  Console.Write("Datos del COntacto 1\n");
                  c2.SetContacto();
                  c2.Saludar();
                  Console.ReadLine();

                  */

                c c5 = new c();
              
                Console.WriteLine(c5.aa());
                Console.WriteLine(c5.bb());
                Console.WriteLine(c5.cc());
                Console.ReadLine();
            }

       }
       class a {
            private string a1;
            public a(){

                a1 = "esto es a";

                }
            public String aa()
            {
                return a1;
            }
           
        }
        class b:a {
            private string b1;
            public b()
            {

                b1 = "esto es b";

            }
            public String bb()
            {
                return b1;
            }
        }
        class c:b {
            private string c1;
            public c() 
            {

                c1 = "esto es c";

            }
            public String cc()
            {
                return c1;
            }
        }
    }

}
