using System.ComponentModel.DataAnnotations;

namespace ClassChallenge1.Models
{
    public class Friend
    {
        [Display(Name = "Id:")]
        [Required(ErrorMessage = "This is required")]
        public int FriendID { get; set; }

        [Display(Name = "Name:")]
        [Required(ErrorMessage = "This is required")]
        public string? FriendName { get; set; }

        [Display(Name = "Place:")]
        [Required(ErrorMessage = "This is required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters.")]
        public string? Place { get; set; }

        [Display(Name = "Favorite Food:")]
        [Required(ErrorMessage = "This is required")]
        public string? FavoriteFood { get; set; }

        [Display(Name = "Favorite Movie:")]
        [Required(ErrorMessage = "This is required")]
        public string? FavoriteMovie { get; set; }

        [Display(Name = "Relationship Status:")]
        [Required(ErrorMessage = "This is required")]
        public string? RelationshipStatus { get; set; }

        // Having a constructor was causing errors when trying to use Dependency injection or setting up the add new friend page (Can't rememeber which one)
        //
        //public Friend(int? friendID = null, string friendName = "", string place = "")
        //{
        //    this.FriendID = friendID;
        //    this.FriendName = friendName;
        //    this.Place = place;
        //}
    }
}
