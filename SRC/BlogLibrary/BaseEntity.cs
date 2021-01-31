using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}