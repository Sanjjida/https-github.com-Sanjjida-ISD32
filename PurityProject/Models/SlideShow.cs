
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PurityProject.Models
{
    [Table("SlideShow")]

    public partial class SlideShow
    {
       
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        

    }
}
