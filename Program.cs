using System;
using System.Collections.Generic;

namespace dreamteam
{
    public interface IClassmate
    {
        string Specialty { get; set; }
        string FirstName{ get; set; }
        string LastName{ get; set; }
        string FullName{ get;} 
        void Work();
        
    }
    class Jason:IClassmate
    {
        public string Specialty { get; set; } = "Coding and playing basketball";
        public string FirstName{ get; set; } = "Jason";
        public string LastName{ get; set; } = " " + "Smith";

        string aj;
        public string FullName => aj = String.Concat(this.FirstName,this.LastName);

        public void Work()
        {
            Console.WriteLine($"{FullName} now starts {Specialty}!");
        }
        
    }

     class Jordan:IClassmate
    {
        public string Specialty { get; set; } = "Coding and being chill";
        public string FirstName{ get; set; } = "Jordan";
        public string LastName{ get; set; } = " " + "Haenens";
        string aj;
        public string FullName => aj = String.Concat(this.FirstName,this.LastName);

        public void Work()
        {
             Console.WriteLine($"{FullName} now starts {Specialty}!");
        }
        
    }

     class Adam:IClassmate
    {
        public string Specialty { get; set; } = "Coding and being the chill dude who taught kids in marching band!";
        public string FirstName{ get; set; } = "Adam";
        public string LastName{ get; set; } = " " + "Reidelbach";
        //public string FullName{ get; set; } = string.Concat(FirstName, LastName);
        string aj;
        public string FullName => aj = String.Concat(this.FirstName,this.LastName);

        public void Work()
        {
             Console.WriteLine($"{FullName} now starts {Specialty}!");
        }
        
    }

     class Ryan:IClassmate
    {
        public string Specialty { get; set; } = "Coding and playing with fidget spinners";
        public string FirstName{ get; set; } = "Ryan";
        public string LastName{ get; set; } = " " + "Mc";
       // public string FullName{ get; set; } = string.Concat(FirstName, LastName);
        string aj;
        public string FullName => aj = String.Concat(this.FirstName,this.LastName);

        public void Work()
        {
             Console.WriteLine($"{FullName} now starts {Specialty}!");
        }
        
    }

    class Ollie:IClassmate
    {
        public string Specialty { get; set; } = "Coding and reading intellectual novels";
        public string FirstName{ get; set; } = "Ollie";
        public string LastName{ get; set; } = " " + "Osinussi";
       // public string FullName{ get; set; } = string.Concat(FirstName, LastName);
        string aj;
        public string FullName => aj = String.Concat(this.FirstName,this.LastName);

        public void Work()
        {
             Console.WriteLine($"{FullName} now starts {Specialty}!");
        }
        
    }

    class Aarti:IClassmate
    {
        public string Specialty { get; set; } = "Coding and ...";
        public string FirstName{ get; set; } = "Aarti";
        public string LastName{ get; set; } = " " + "Jaisinghani";
       // public string FullName{ get; set; } = string.Concat(FirstName, LastName);
        string aj;
        public string FullName => aj = String.Concat(this.FirstName,this.LastName);

        public void Work()
        {
             Console.WriteLine($"{FullName} now starts {Specialty}!");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create two groups (i.e. List) that will hold three teammates each. 
            These two lists represent one team that will be the server side team, 
            and one that will be the client side team
            */
            List<IClassmate> serverSide = new List<IClassmate>();
            List<IClassmate> clientSide = new List<IClassmate>();

            //Instantiate one instance of each of your teammates.
            Jason jason = new Jason();
            Jordan jordan = new Jordan();
            Adam adam = new Adam();
            Ryan ryan = new Ryan();
            Ollie ollie = new Ollie();
            Aarti aarti = new Aarti();

            serverSide.Add(jason);
            serverSide.Add(aarti);
            serverSide.Add(adam);
            clientSide.Add(ryan);
            clientSide.Add(ollie);
            clientSide.Add(jordan);

            foreach(var s in serverSide)
            {
                s.Work();
            }

            foreach(var c1 in clientSide)
            {
                c1.Work();
            }

        }
    }
}
