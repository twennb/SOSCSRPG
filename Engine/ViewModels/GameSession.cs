using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession: INotifyPropertyChanged
    {
        private Location _currentLocation;

        public Player CurrentPlayer { get; set; } // Defines the Player property CurrentPlayer
        public Location CurrentLocation
        {
            get {  return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToEast");
                OnPropertyChanged("HasLocationToSouth");
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
        {                       // This constructor will set the player data when it loads, using the CurrentPlayer
            CurrentPlayer = new Player(); // instatiates the CurrentPlayer object from the Player class
            CurrentPlayer.Name = "Tom"; // sets the Name attribute to Tom
            CurrentPlayer.CharacterClass = "Mage";
            CurrentPlayer.HitPoints = 6;
            CurrentPlayer.Mana = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

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

        public event PropertyChangedEventHandler PropertyChanged; // define a public event
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // check for when something wants to be changed
        }
    }
}
