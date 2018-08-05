using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    //delegados
    public delegate void DelegateString(string s);
    public delegate void DelegateInt(int i);

    public class Contact
    {
        //Lista
        public static List<Contact> contacts = new List<Contact>();
        //Delegados
        public static DelegateString metodstring = new DelegateString(searchName);
        public static DelegateInt metodint = new DelegateInt(searchId);
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Primeros 5
        public void Initials()
        {
            Contact c1 = new Contact();
            c1.Id = contacts.Count() + 1;
            c1.Name = "Diony";
            c1.Phone = "809-536-0110";
            c1.Email = "diony1991@gmail.com";
            contacts.Add(c1);

            Contact c2 = new Contact();
            c2.Id = contacts.Count() + 1;
            c2.Name = "Eric";
            c2.Phone = "809-569-4568";
            c2.Email = "thealchemist@gmail.com";
            contacts.Add(c2);

            Contact c3 = new Contact();
            c3.Id = contacts.Count() + 1;
            c3.Name = "Ichigo";
            c3.Phone = "809-151-5151";
            c3.Email = "substitute@gmail.com";
            contacts.Add(c3);

            Contact c4 = new Contact();
            c4.Id = contacts.Count() + 1;
            c4.Name = "Pablo";
            c4.Phone = "809-233-5688";
            c4.Email = "pablito@gmail.com";
            contacts.Add(c4);

            Contact c5 = new Contact();
            c5.Id = contacts.Count() + 1;
            c5.Name = "Lucas";
            c5.Phone = "809-632-7896";
            c5.Email = "alucard@gmail.com";
            contacts.Add(c5);

        }

        //Agregar
        public void AddContac()
        {
            Contact c = new Contact();
            c.Id = contacts.Count() + 1;
            Console.Write("Nombre: ");
            c.Name = Console.ReadLine();
            Console.Write("Teléfono: ");
            c.Phone = Console.ReadLine();
            Console.Write("E-mail: ");
            c.Email = Console.ReadLine();
            Console.WriteLine();
            contacts.Add(c);
        }

        //Buscar por ID
        public static void searchId(int id)
        {
            var search = contacts.FindAll(c => c.Id == id);

            foreach (var s in search)
            {
                Console.WriteLine("*********************************************************************************");
                Console.WriteLine($"{ s.Id.ToString() } - { s.Name }");
                Console.WriteLine($"{ s.Phone } - { s.Email }");
                Console.WriteLine();
            }
        }

        public static void searchName(string name)
        {
            var search = contacts.FindAll(c => c.Name == name);

            foreach (var s in search)
            {
                Console.WriteLine("*********************************************************************************");
                Console.WriteLine($"{ s.Id.ToString() } - { s.Name }");
                Console.WriteLine($"{ s.Phone } - { s.Email }");
                Console.WriteLine();
            }
        }

        //Eliminar
        public static void delete (int id)
        {
            var search = contacts.FindAll(c => c.Id == id);

            foreach (var s in search)
            {
                contacts.Remove(s);                
            }
            
        }

        public static void deleteName(string name)
        {
            var search = contacts.FindAll(c => c.Name == name);

            foreach (var s in search)
            {
                contacts.Remove(s);
            }

        }

        public void ShowContac()
        {
            //Muestra los contactos
            foreach (var c in contacts)
            {
                Console.WriteLine("*********************************************************************************");
                Console.WriteLine($"{ c.Id.ToString() } - { c.Name }");
                Console.WriteLine($"{ c.Phone } - { c.Email }");
                Console.WriteLine();
            }
        }
        
    }  
}