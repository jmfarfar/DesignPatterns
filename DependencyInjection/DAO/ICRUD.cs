using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    internal interface ICRUD<T>
    {
        List<T> ListAll();
        T ReadById(int id);
        void Register(T person);
        void Update(T person);
        void Delete(int id);
    }
}
