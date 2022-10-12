using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    internal class PersonDAO : IPersonDAO
    {
        public void Delete(int id)
        {
            Console.WriteLine($"Person with id: {id} has been deleted.");
        }

        public List<Person> ListAll()
        {
            List<Person> list = new List<Person>();
            Person person = new Person();
            person.Id = 1;
            person.Names = "John";

            list.Add(person);

            person = new Person();
            person.Id = 2;
            person.Names = "Wayne";

            list.Add(person);

            return list;
        }

        public Person ReadById(int id)
        {
            return null;
        }

        public void Register(Person person)
        {
            Console.WriteLine($"Person {person} registered.");
        }

        public void Update(Person person)
        {
            Console.WriteLine($"Person {person} updated.");
        }
    }
}
