using System;
using System.Collections.Generic;

namespace Introduccion
{
    class Program
    {
        static void Main(string[] args)
        {
            //var emmanuel = new SportyPerson("Emmanuel", 34, "Argentina");
            //Console.WriteLine(emmanuel.Show());
            //emmanuel.Run();

            List<IVolador> patos = new List<IVolador>();
            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();
            patos.Add(pato1);
            patos.Add(pato2);
            patos.Add(pato3);

            AVolar(patos);

            Console.ReadKey();
        }

        public static void AVolar(List<IVolador> aves) 
        {
            foreach (var ave in aves)
            {
                ave.Volar();
            }
        }
    }

    abstract class Person
    {
        public string name;
        public int age;
        public string nationality;

        public Person(string name, int age, string nationality)
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality;
        }

        public string Show()
        {
            return $"{this.name} - {this.age} - {this.nationality}";
        }

    }

    class SportyPerson : Person
    {
        public SportyPerson(string name, int age, string nationality) : base(name, age, nationality)
        {

        }

        public void Run()
        {
            Console.WriteLine(this.name + " esta corriendo");
        }
    }


    interface IVolador
    {
        public void Volar();
    }

    interface ICaminador
    {
        public void Caminar();
    }

    public class Pato: IVolador, ICaminador
    {
        public void Volar()
        {
            Console.WriteLine("Volando");
        }

        public void Caminar()
        {
            Console.WriteLine("Caminando");
        }
    }


}
