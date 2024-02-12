using Newtonsoft.Json;
using System;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe objemp = new Employe();

            objemp.Object_json();
            objemp.json_Object();
            Console.ReadLine();
        }
    }

    class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employe() { }



        public void Object_json()
        {

            Employe objemp = new Employe();
            objemp.Id = 100;
            objemp.Name = "test";
            objemp.Salary = 345;
            string json = JsonConvert.SerializeObject(objemp);
            Console.WriteLine(json);
        }

        public void json_Object()
        {
            string json = @"{
               'Id':1,
             'Name': 'Sahithi',
             'Salary': 268,

            }";

            Employe m = JsonConvert.DeserializeObject<Employe>(json);
            Console.WriteLine($"ID: {m.Id}, Name: {m.Name}, Salary: {m.Salary}");
            Console.ReadLine();
        }
    }
}