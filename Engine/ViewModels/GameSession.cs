using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading.Channels;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        private Location _currentLocation;

        public Player CurrentPlayer { get; set; } // Defines the Player property CurrentPlayer
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToSouth));
            }
        }
        public World CurrentWorld { get; set; }
        public bool HasLocationToNorth
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; }
        }
        public bool HasLocationToWest
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null; }
        }
        public bool HasLocationToEast
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null; }
        }
        public bool HasLocationToSouth
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null; }
        }

        public GameSession() // Done within the GameSession class just for demonstration, will be done from elsewhere
        { 
            CurrentPlayer = new Player
                                { 
                                    Name = "Tom",
                                    CharacterClass = "Mage",
                                    HitPoints = 6,
                                    Mana = 10,
                                    Gold = 0,
                                    ExperiencePoints = 0,
                                    Level = 1
                                };
            
            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }

        public void MoveNorth()
        { 
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1 , CurrentLocation.YCoordinate);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
    }
}
