using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAPI.Models
{
    public class ToDoItemModel
    {
        [Key]
        public int ItemId { get;  set; }

        [Required(ErrorMessage = "ItemName is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "ItemDescription is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string ItemDescription { get; set; }

        [Required(ErrorMessage = "ItemStatus is required")]
        [Column(TypeName = "bit")]
        public bool ItemStatus { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Date { get; set; }
        
       /* [Required(ErrorMessage = "Date is required")]
        [Column(TypeName = "Date")]
        public System.DateTime DateTime { get; set; } */
    }
}