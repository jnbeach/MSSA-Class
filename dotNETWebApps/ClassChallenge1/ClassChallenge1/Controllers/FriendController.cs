using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClassChallenge1.Models;
using ClassChallenge1.Services;

namespace ClassChallenge1.Controllers
{
    public class FriendController : Controller
    {
        IFriendList _listOfFriends; //Must be an interface

        //Inject service into Controller
        public FriendController(IFriendList inputFriends) //Input the Interface to call the service.
        {
            // Dependency Injection occurs here.
            _listOfFriends = inputFriends;
        }
        public IActionResult Index()
        {

            return View(_listOfFriends);
        }

        public IActionResult FriendDetails(int id)
        {
            Friend friend = _listOfFriends.GetFriendById(id);
            return View(friend);
        }

        public IActionResult FriendRemoved(int id)
        {
            Friend friend = _listOfFriends.GetFriendById(id);
            _listOfFriends.RemoveFriendById(id);
            return View(friend);
        }

        [HttpGet]
        public IActionResult InsertNewFriend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertNewFriend(Friend friend)
        {
            if (ModelState.IsValid) //If all of the validations are good, then add the friend and take it back to index.
            {
                _listOfFriends.listOfFriends.Add(friend);
                return RedirectToAction("Index");
            }
            
            return View();
        }

        [HttpGet]
        public IActionResult UpdateFriend(int id)
        {
            Friend friend = _listOfFriends.GetFriendById(id);
            return View(friend);
        }

        [HttpPost]
        public IActionResult UpdateFriend(Friend updatedFriend)
        {
            //Friend currentFriend = _listOfFriends.GetFriendById(updatedFriend.FriendID);
            _listOfFriends.listOfFriends[updatedFriend.FriendID - 1] = updatedFriend;
            return View();
        }
    }
}

//Dependency Injection:
//1: Make interface from class. (FriendList : IFriendList)
//2: Create a service (This is the singleton in Program.cs (startup.cs for net5.0)
//3: Define a property that uses the interface (IFriendList _listOfFriends)
