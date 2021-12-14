
using ClassChallenge1.Models;

namespace ClassChallenge1.Services
{
    public interface IFriendList
    {
        List<Friend> listOfFriends { get; set; }

        //Needed to add this to the interface once we created a new method in the FriendList service.
        public Friend GetFriendById(int id);
        public void RemoveFriendById(int id);
    }
}