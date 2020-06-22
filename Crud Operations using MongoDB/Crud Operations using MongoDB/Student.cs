using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Operations_using_MongoDB
{
   public class Student
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Name")]
        public String Name { get; set; }
        [BsonElement("Email")]
        public String Email { get; set; }

        [BsonElement("Contact")]
        public String Contact { get; set; }

        [BsonElement("Department")]
        public String Department { get; set; }

        public Student(string name , string email , string contact , string department)
        {
            Name = name;
            Email = email;
            Contact = contact;
            Department = department;

        }
    }
}
