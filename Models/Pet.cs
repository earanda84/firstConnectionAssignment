#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace firstConnectionAssignment.Models
{
    public enum PetType
    {
        Cat,
        Dog,
        Bird
    }
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        public string Name { get; set; }

        public PetType Type { get; set; }

        public int Age { get; set; }

        public bool Hair { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}