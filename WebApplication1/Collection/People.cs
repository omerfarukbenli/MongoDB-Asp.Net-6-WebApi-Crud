﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Collection
{
    public class People
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("age")]
        public int? Age { get; set; }

        [BsonElement("phonenumbers")]
        public List<string>? PhoneNumbers { get; set; }
    }
}
