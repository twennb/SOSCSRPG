using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; } // Defines the Player property CurrentPlayer
        public Location CurrentLocation { get; set; }

        public GameSession() // Done within the GameSession class just for demonstration, will be done from elsewhere
        {                       // This constructor will set the player data when it loads, using the CurrentPlayer
            CurrentPlayer = new Player(); // instatiates the CurrentPlayer object from the Player class
            CurrentPlayer.Name = "Tom"; // sets the Name attribute to Tom
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.HitPoints = 6;
            CurrentPlayer.Mana = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house!";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.png";
        }
    }
}
