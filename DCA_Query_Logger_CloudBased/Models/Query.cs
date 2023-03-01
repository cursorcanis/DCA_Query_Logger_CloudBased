using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DCA_Query_Logger_CloudBased.Models {
    public class Query 
        {
        public int Id { get; set; }
        [Display(Name = "Title of Query")]
        public string? Title_of_Query { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Type of Query")]
        public string? Type_of_Query { get; set; }
        //public decimal Price { get; set; }
    }
}
