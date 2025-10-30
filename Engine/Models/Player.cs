using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private int _experiencePoints;
        public string Name { get; set; } // defines a Name attribute of type string where the value can be defined "set" and read "get"
        public string CharacterClass { get; set; }
        public int HitPoints { get; set; }
        public int Mana {  get; set; }
        public int ExperiencePoints
        {
            get { return _experiencePoints; } // when something tries to get the value, show from _experiencePoints
            set
            {
                _experiencePoints = value; // when something tries to set the value, pass on to _experiencePoints
                OnPropertyChanged("ExperiencePoints"); // define which property this change updates
            }
        } 
        public int Level { get; set; }
        public int Gold { get; set; }

        public event PropertyChangedEventHandler PropertyChanged; // define a public event
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // check for when something wants to be changed
        }

    }
}
