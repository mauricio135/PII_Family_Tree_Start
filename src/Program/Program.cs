using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona ruben = new Persona("Ruben", 67);
            Persona moria = new Persona ("Moria", 40);

            Persona  javier = new Persona("Javier",15);            
            Persona  carlos = new Persona("Carlos",88);
            
            Persona  mia = new Persona("Mia",4);
            Persona  santino = new Persona("Santino",3);
            
            Persona nahuel =new Persona("Nahuel",20);
            Persona mariam =new Persona("Miriam",35);
        
            Node<Persona> nCarlos = new Node<Persona>(carlos);
            Node<Persona> nRuben = new Node<Persona>(ruben);
            Node<Persona> nMoria = new Node<Persona>(moria);
            Node<Persona> nJavier = new Node<Persona>(javier);
            Node<Persona> nNahuel = new Node<Persona>(nahuel);
            Node<Persona> nSantino= new Node<Persona>(santino);
            Node<Persona> nMariam = new Node<Persona>(mariam);
            Node<Persona> nMia = new Node<Persona>(mia);

            nCarlos.AddChildren(nRuben);
            
            nRuben.AddChildren(nMoria);
            nRuben.AddChildren(nMariam);

            nMoria.AddChildren(nJavier);

            nMariam.AddChildren(nMia);
            nMariam.AddChildren(nSantino);
            nMariam.AddChildren(nNahuel);



            AgeVisitor ageVisitor = new AgeVisitor();
            nCarlos.accept(ageVisitor);
            Console.WriteLine($"La suma de edades es {ageVisitor.AgeTotal}");

            OldestSonVisitor oldVisitor = new OldestSonVisitor();
            nCarlos.accept(oldVisitor);
            Console.WriteLine($"El hijo más grande es {oldVisitor.Oldest.Nombre}");

            LongestNameVisitor nameVisitor = new LongestNameVisitor();
            nCarlos.accept(nameVisitor);
            Console.WriteLine($"El nombre más largo es {nameVisitor.LongName.Nombre}");
        }
    }
}
