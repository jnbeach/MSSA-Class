using ClassChallenge1.Models;

namespace ClassChallenge1.Services
{
    public interface IFriendList
    {
        //Don't need this anymore now that we are using the database to store info.
        //List<Friend> listOfFriends { get; set; }

        //Needed to add this to the interface once we created a new method in the FriendList service.
        public List<Friend> GetFriends();
        public Friend GetFriendById(int id);
        public void AddFriend(Friend friend);
        public void RemoveFriendById(int id);

        public void UpdateFriend(Friend friend);
    }
}