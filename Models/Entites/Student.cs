using System.ComponentModel.DataAnnotations;

namespace asp_crud_app.Models.Entites
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Subscribed { get; set; }


    }
}
