using System.ComponentModel.DataAnnotations;


namespace HelperTag.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        public string? Family { get; set; }
        [Required(ErrorMessage ="le Nome est obligatoire.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Le genre est obligatoire.")]
        public bool Gender { get; set; }
        
    }
}
