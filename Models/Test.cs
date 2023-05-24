using System.ComponentModel.DataAnnotations;

namespace WebApplication7._0.Models
{
    public class Test
    {

        public int Id { get; set; }
        [StringLength(20)]
        public string? Name { get; set; }
        [StringLength(20)]
        public string? Description { get; set; }
        public string? Author { get; set; }
        
    }
}
