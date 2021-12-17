using System.Collections.Generic;
using ClassChallenge1.Models;

namespace ClassChallenge1.Services
{
    public class FriendList : IFriendList
    {
        public List<Friend> listOfFriends { get; set; }

        public FriendList()
        {
            InitializeListOfFriends();
        }
        public void InitializeListOfFriends()
        {
            listOfFriends = new List<Friend>()
            {
                new Friend(){FriendID = 1, FriendName = "Steve",Place = "Ohio, USA", FavoriteFood="Cheeseburgers", FavoriteMovie="Inception", RelationshipStatus="Married"},
                new Friend(){FriendID = 2, FriendName = "Greg",Place = "Minnesota, USA", FavoriteFood="Spaghetti", FavoriteMovie="Pacific Rim", RelationshipStatus="Married" },
                new Friend(){FriendID = 3, FriendName = "Chad",Place = "Washington, USA", FavoriteFood="Lasagna", FavoriteMovie="Lord of the Rings", RelationshipStatus="Married" },
                new Friend(){FriendID = 4, FriendName = "Leon",Place = "Mexico", FavoriteFood="Pizza", FavoriteMovie="The Shining", RelationshipStatus="Married" },
            };
        }

        public Friend GetFriendById(int id)
        {
            // LINQ or Lambda statement can get this.
            Friend friend = this.listOfFriends.FirstOrDefault(friend => friend.FriendID == id);
            return friend;
        }

        public void RemoveFriendById(int id)
        {
            Friend friend = GetFriendById(id);
            this.listOfFriends.Remove(friend);
        }    
    }
}
