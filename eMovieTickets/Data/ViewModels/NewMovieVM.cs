using eMovieTickets.Data;
using eMovieTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is requried")]
        [Display(Name ="Movie Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is requried")]
        [Display(Name ="Movie Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is requried")]
        [Display(Name ="Price in $")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Movie poster URL is requried")]
        [Display(Name ="Movie poster URL")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage = "Start Date is requried")]
        [Display(Name ="Movie Start Date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End Date is requried")]
        [Display(Name ="Movie End Date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Movie category is requried")]
        [Display(Name ="Select Category")]
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        [Required(ErrorMessage = "Movie actors is requried")]
        [Display(Name ="Select Actors")]
        public List<int> ActorIds { get; set; }
        [Required(ErrorMessage = "Movie cinema is requried")]
        [Display(Name ="Select a Cinema")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Movie producer is requried")]
        [Display(Name ="Select a Producer")]
        public int ProducerId { get; set; }
    }
}
