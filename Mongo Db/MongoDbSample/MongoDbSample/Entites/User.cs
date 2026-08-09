using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace MongoDbSample.Entites
{
    internal class User
    {
        [BsonId]
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        public string Family { get; set; }

        public List<string> Phones { get; set; }

        [BsonIgnore]
        public string FullName
        {
            get
            {
                return Name + " " + Family;
            }
        }
    }
}
