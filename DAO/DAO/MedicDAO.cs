using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    internal class MedicDAO : IMedicDAO
    {
        public void Delete(int id)
        {
            Console.WriteLine($"Medic with id: {id} has been deleted.");
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public List<Medic> ListAll()
        {
            List<Medic> list = new List<Medic>();
            Medic Medic = new Medic();
            Medic.Id = 1;
            Medic.Names = "John";

            list.Add(Medic);

            Medic = new Medic();
            Medic.Id = 2;
            Medic.Names = "Wayne";

            list.Add(Medic);

            return list;
        }

        public Medic ReadById(int id)
        {
            return null;
        }

        public void Register(Medic Medic)
        {
            Console.WriteLine($"Medic {Medic} registered.");
        }

        public void Update(Medic Medic)
        {
            Console.WriteLine($"Medic {Medic} updated.");
        }
    }
}
