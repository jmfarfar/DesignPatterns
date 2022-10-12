using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    internal interface IMedicDAO : ICRUD<Medic>
    {

        void Heal();
    }
}
