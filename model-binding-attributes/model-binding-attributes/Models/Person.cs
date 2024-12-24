using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace model_binding_attributes.Models
{
    public class Person
    {
        [BindRequired]
        public int Id { get; set; }
        public string Name { get; set; }
        public string family { get; set; }
        [BindRequired]
        public int age { get; set; }
    }
}
