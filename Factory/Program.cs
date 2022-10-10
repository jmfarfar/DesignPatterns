// See https://aka.ms/new-console-template for more information


using Factory;

FabricConnection fabric = new FabricConnection();

var conn1 = fabric.GetConnection("MySql");
conn1.Connect();
conn1.Disconnect();

var conn2 = fabric.GetConnection("Oracle");
conn2.Connect();
conn2.Disconnect();

var conn3 = fabric.GetConnection("SqlServer");
conn3.Connect();
conn3.Disconnect();

var conn4 = fabric.GetConnection("OtherDB");
conn4.Connect();
conn4.Disconnect();
