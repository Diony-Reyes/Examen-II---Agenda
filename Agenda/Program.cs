using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {

       static void Main(string[] args)
        {
            //Console.WriteLine(Contacts.sumar(2,3));
            int option = 0;
            bool salir = false;

            Contact c = new Contact();
            c.Initials();
            c.ShowContac();

            //menu
            while (salir == false)
            {
                Console.WriteLine("*********************************************************************************");
                Console.WriteLine("1- Listar");
                Console.WriteLine("2- Agregar");
                Console.WriteLine("3- Buscar por ID");
                Console.WriteLine("4- Buscar por Nombre");
                Console.WriteLine("5- Salir");

                Console.WriteLine();
                Console.Write("Seleccione una opción: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                
                switch (option)
                {
                    case 1:
                        c.ShowContac();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        c.AddContac();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("ID: ");

                        Contact.metodint += Contact.delete;
                        Contact.metodint.Invoke(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.Write("Presione 1 si desea eliminarlo: ");
                        int option2 = Convert.ToInt32(Console.ReadLine());

                        if (option2==1)
                        {
                            Contact.metodint += Contact.delete;
                            
                        }
                        break;

                    case 4:
                        Console.Write("Nombre: ");
                        Contact.metodstring += Contact.deleteName;
                        Contact.metodstring.Invoke(Console.ReadLine());

                        Console.WriteLine();
                        Console.Write("Presione 1 si desea eliminarlo: ");
                        int option3 = Convert.ToInt32(Console.ReadLine());

                        if (option3 == 1)
                        {
                            Contact.metodstring += Contact.deleteName;

                        }
                        
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        break;
                }
            }
            
            
        }        

        
    }
}
