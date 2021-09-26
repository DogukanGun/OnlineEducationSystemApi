using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Hocam.Core.Data.Abstractions
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }

        string CreatedBy { get; set; }
    }
}
