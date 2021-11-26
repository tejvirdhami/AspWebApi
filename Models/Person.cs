using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Person
    {
        
        [Key] // This will point the property below as PK
        public int id { get; set;}  //Protection, security

        public string Name { get; set;}

        public string City { get; set;}

        public int Age { get; set;}


    }
}