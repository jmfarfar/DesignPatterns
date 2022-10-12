// See https://aka.ms/new-console-template for more information

// DI: A way to keep an instance decoupled from the code. This way you can have multiple implementations without the need to create an instance for every job.
// There are three ways to implement a DI:
// By Constructor
// By Method
// By Interface

using DAO.DAO;
using DependencyInjection.DAO;

IConnection conn1 = new ConnectionMySql("Jhon", "abc123", "localhost");

IConnection conn2 = new ConnectionPostgress("Milton", "abc123", "192.168.1.1");

IPersonDAO dao = new PersonDAO(conn2);

dao.ListAll();
