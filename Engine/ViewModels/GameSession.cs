using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player CurrentPlayer { get; set; } // Defines the Player object CurrentPlayer

        public GameSession()
        { 
            CurrentPlayer = new Player(); // instatiates the CurrentPlayer object from the Player class
            CurrentPlayer.Name = "Tom"; // sets the Name attribute to Tom
            CurrentPlayer.Gold = 1000000;
        }
    }
}
