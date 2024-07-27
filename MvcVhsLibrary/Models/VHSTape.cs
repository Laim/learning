using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcVhsLibrary.Models
{
    [PrimaryKey(nameof(Id))]
    public class VHSTape
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        public required string MovieName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public required DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }
    
        public required string Barcode { get; set; }

        public required string TotalTime { get; set; }

        public required string Company { get; set; }

        public required string Country { get; set; }
    }
}
