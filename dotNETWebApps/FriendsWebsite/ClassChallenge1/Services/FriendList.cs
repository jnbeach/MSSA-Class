using System.Collections.Generic;
using ClassChallenge1.Models;
using ClassChallenge1.Data;
using Microsoft.EntityFrameworkCore;

namespace ClassChallenge1.Services
{
    public class FriendList : IFriendList
    {
        //Before we used the service FriendList to display the data. Now we are using this service to fetch and send things to the database, using FriendContext.
        
        //public List<Friend> listOfFriends { get; set; }


        private FriendContext dataRunner;
        public FriendList(FriendContext friendDatabase)
        {
            dataRunner = friendDatabase;
            // //See below: This is now in FriendContext.cs
            //InitializeListOfFriends();
        }

        //This is now in FriendContext.cs
        //public void InitializeListOfFriends()
        //{
        //    listOfFriends = new List<Friend>()
        //    {
        //        new Friend(){FriendID = 1, FriendName = "Steve",Place = "Ohio, USA", FavoriteFood="Cheeseburgers", FavoriteMovie="Inception", RelationshipStatus="Married"},
        //        new Friend(){FriendID = 2, FriendName = "Greg",Place = "Minnesota, USA", FavoriteFood="Spaghetti", FavoriteMovie="Pacific Rim", RelationshipStatus="Married" },
        //        new Friend(){FriendID = 3, FriendName = "Chad",Place = "Washington, USA", FavoriteFood="Lasagna", FavoriteMovie="Lord of the Rings", RelationshipStatus="Married" },
        //        new Friend(){FriendID = 4, FriendName = "Leon",Place = "Mexico", FavoriteFood="Pizza", FavoriteMovie="The Shining", RelationshipStatus="Married" },
        //    };
        //}

        public List<Friend> GetFriends()
        {
            return dataRunner.Friends.ToList();
        }
        public Friend GetFriendById(int id)
        {
            return dataRunner.Friends.FirstOrDefault(friend => friend.FriendID == id);
            // LINQ or Lambda statement can get this.
            //Friend friend = this.listOfFriends.FirstOrDefault(friend => friend.FriendID == id);
            //return friend;
        }

        public void AddFriend(Friend friend)
        {
            dataRunner.Friends.Add(friend);
            dataRunner.SaveChanges();
        }
        public void RemoveFriendById(int id)
        {
            Friend friend = GetFriendById(id);
            dataRunner.Friends.Remove(friend);
            dataRunner.SaveChanges();
            //Friend friend = GetFriendById(id);
            //this.listOfFriends.Remove(friend);
        }
        public void UpdateFriend(Friend friend)
        {
            dataRunner.Entry(friend).State = EntityState.Modified;
            dataRunner.SaveChanges();
        }
        
    }
}
