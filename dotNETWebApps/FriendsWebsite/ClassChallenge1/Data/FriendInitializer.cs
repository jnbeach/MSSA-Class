using ClassChallenge1.Models;

namespace ClassChallenge1.Data
{
    public static class FriendInitializer
    {
        public static void Initialize(FriendContext context)
        {
            context.Database.EnsureCreated();

            //Look for any friends. If there are any, assume the Db has been initialized.
            if (context.Friends.Any())
            {
                return;
            }
            
            //Make the initial list of friends. 
            List<Friend> friends = new List<Friend> {
                new Friend() { FriendID = 1, FriendName = "Steve", Place = "Ohio, USA", FavoriteFood = "Cheeseburgers", FavoriteMovie = "Inception", RelationshipStatus = "Married" },
                new Friend() { FriendID = 2, FriendName = "Greg", Place = "Minnesota, USA", FavoriteFood = "Spaghetti", FavoriteMovie = "Pacific Rim", RelationshipStatus = "Married" },
                new Friend() { FriendID = 3, FriendName = "Chad", Place = "Washington, USA", FavoriteFood = "Lasagna", FavoriteMovie = "Lord of the Rings", RelationshipStatus = "Married" },
                new Friend() { FriendID = 4, FriendName = "Leon", Place = "Mexico", FavoriteFood = "Pizza", FavoriteMovie = "The Shining", RelationshipStatus = "Married" }
            };
            //Send each friend to the Database
            friends.ForEach(f => context.Friends.Add(f));
            
            //Save changes.
            context.SaveChanges();

        }
    }


}
