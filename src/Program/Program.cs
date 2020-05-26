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

            nRuben.AddChildren(nJavier);
            nMariam.AddChildren(nNahuel);

            nNahuel.AddChildren(nMia);
            nNahuel.AddChildren(nSantino);



            // visitar el árbol aquí
        }
    }
}
