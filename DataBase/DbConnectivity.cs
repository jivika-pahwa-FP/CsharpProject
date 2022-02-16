using System;
using DataBase.Models;

namespace DataBase
{
    class DbConnectivity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database  Connectivity!");

            DatabaseTrainingContext db = new DatabaseTrainingContext();
            JivikaTable table = new JivikaTable();
            table.Id = "101";
            table.Name = "Employee 1";
            table.Age = 23;

            db.JivikaTables.Add(table);
            db.SaveChanges();

            foreach(var i in db.JivikaTables){
                System.Console.WriteLine( "Name : {0} Age: {1} ",i.Name,i.Age );
            }

            
        }
    }
}
