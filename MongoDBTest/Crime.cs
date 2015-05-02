using MongoDB.Bson;
using System;
using System.Text;

namespace MongoDBTest
{
    public class Crime
    {
        public ObjectId Id { get; set; }

        public int ID { get; set; }

        public string CaseNumber { get; set; }

        public DateTime Date { get; set; }

        public string Block { get; set; }

        public string IUCR { get; set; }

        public string PrimaryType { get; set; }

        public string Description { get; set; }

        public string LocationDescription { get; set; }

        public bool Arrest { get; set; }

        public bool Domestic { get; set; }

        public int Beat { get; set; }

        public int District { get; set; }

        public int Ward { get; set; }

        public int Community { get; set; }

        public int FBICode { get; set; }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public int Year { get; set; }

        public DateTime UpdatedOn { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("ID: " + this.ID);
            builder.AppendLine("Case Number: " + this.CaseNumber);
            builder.AppendLine("Date: " + this.Date.Date);
            builder.AppendLine("Block: " + this.Block);
            builder.AppendLine("IUCR: " + this.IUCR);
            builder.AppendLine("Primary Type: " + this.ID);
            builder.AppendLine("Description: " + this.Description);
            builder.AppendLine("Location Description: " + this.LocationDescription);
            builder.AppendLine("Arrest: " + this.Arrest);
            builder.AppendLine("Domestic: " + this.Domestic);
            builder.AppendLine("Beat: " + this.Beat);
            builder.AppendLine("District: " + this.District);
            builder.AppendLine("Ward: " + this.Ward);
            builder.AppendLine("Community: " + this.Community);
            builder.AppendLine("FBI Code: " + this.FBICode);
            builder.AppendLine("X-Coordinate: " + this.XCoordinate);
            builder.AppendLine("Y-Coordinate: " + this.YCoordinate);
            builder.AppendLine("Year: " + this.Year);
            builder.AppendLine("Updated On: " + this.UpdatedOn);
            builder.AppendLine("Latitude: " + this.Latitude);
            builder.AppendLine("Longitude: " + this.Longitude);

            return builder.ToString();
        }
    }
}
