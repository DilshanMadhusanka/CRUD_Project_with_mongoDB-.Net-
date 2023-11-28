
using MongoDB.Bson; // these two namespaces related with mongoDB 
using MongoDB.Bson.Serialization.Attributes;

namespace CRUD_Project_with_mongoDB.Model
{ public class Student
    {


        [BsonID]
        [BsonRepresentation(BsonType.ObjectId)]  // convert mongoDB data type into dotnet data type 
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

        [BsonElement("course")]
        public string[]? Course { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; } = string.Empty;

        [BsonElement("Age")]
        public int Age { get; set; }

    }
}
