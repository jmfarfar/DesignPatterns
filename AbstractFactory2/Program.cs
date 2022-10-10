// See https://aka.ms/new-console-template for more information


using AbstractFactory2;
using AbstractFactory2.Interfaces;

IAbstractFactory factoryDB = FactoryProducer.GetFactory("DB");
IConnection conn = factoryDB.getDB("MySql");

conn.Connect();
conn.Disconnect();


IAbstractFactory factoryREST = FactoryProducer.GetFactory("REST");
IConnectionREST connREST = factoryREST.getREST("Sales");

connREST.readURL("http://www.google.com/");
