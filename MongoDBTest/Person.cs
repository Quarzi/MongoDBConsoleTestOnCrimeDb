using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBTest
{
    class Person
    {
        public ObjectId Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("FirstName: " + this.FirstName);
            builder.AppendLine("MiddleName: " + this.MiddleName);
            builder.AppendLine("LastName: " + this.LastName);
            builder.AppendLine("Description: " + this.Description);
            builder.AppendLine("Age In Years: " + this.Age);

            return builder.ToString();
        }
    }
}
