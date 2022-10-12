// See https://aka.ms/new-console-template for more information


// DAO: Allow us to decouple our code by using interfaces. Also promotes the use of generics to implement a base behavior among our classes but also some custom 
// implementation regarding our class.


using DAO.DAO;
using DAO.Models;

ICRUD<Person> dao = new PersonDAO();
dao.ListAll().ForEach(x => Console.WriteLine(x.Names));

Person per = new Person();
per.Id = 3;
per.Names = "Noe";
dao.Register(per);