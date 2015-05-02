using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;


namespace MongoDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connecting Client
            var client = new MongoClient("mongodb://192.168.1.161:27017/");

            //Getting Db's
            var personDb = client.GetDatabase("CSharpTestDb");
            var crimedb = client.GetDatabase("test");

            //Getting Collections
            var PersonCollection = personDb.GetCollection<Person>("Person");
            var CrimeCollection = crimedb.GetCollection<BsonDocument>("crimes");

            //Insert person into MongoDB
            var insertTask = PersonCollection.InsertOneAsync(new Person() { FirstName = "Kim", MiddleName = "Jan", LastName = "Andersen", Description = "The Coder", Age = 32 });
            insertTask.Wait();

            //Find that person agin
            var findPersonTask = PersonCollection.Find(person => person.FirstName.ToLower() == "Kim".ToLower()).ToListAsync();
            findPersonTask.Wait();

            //Show result from find
            foreach (var item in findPersonTask.Result)
            {
                Console.WriteLine(item.ToString());
            }

            //Find Crime from ID
            var findCrimeTask = CrimeCollection.Find(crime => crime["ID"] == 9843020).ToListAsync();
            findCrimeTask.Wait();

            //Show result from find
            foreach (var crimeDoc in findCrimeTask.Result)
            {
                for (int i = 0; i < crimeDoc.ElementCount; i++)
                {
                    Console.WriteLine(crimeDoc.Names.ElementAt(i) + ": " + crimeDoc[i].ToString());
                }
            }
        }
    }
}
