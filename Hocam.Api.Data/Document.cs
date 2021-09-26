
 using Hocam.Core.Data.Abstractions;
using MongoDB.Bson;
using System;

namespace Hocam.Core.Data
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }
        public DateTime CreatedAt { get => Id.CreationTime; }
        public string CreatedBy { get; set; }
    }
}
