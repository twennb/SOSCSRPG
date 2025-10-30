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
        // private variables
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _mana;
        private int _experiencePoints;
        private int _level;
        private int _gold;
        
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        
        } // defines a Name attribute of type string where the value can be defined "set" and read "get"
        public string CharacterClass
        {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }

        }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }

        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                _mana = value;
                OnPropertyChanged("Mana");
            }

        }
        public int ExperiencePoints
        {
            get { return _experiencePoints; } // when something tries to get the value, show from _experiencePoints
            set
            {
                _experiencePoints = value; // when something tries to set the value, pass on to _experiencePoints
                OnPropertyChanged("ExperiencePoints"); // passes on which property this change updates
            }
        } 
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }

        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged; // define a public event
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); // check for when something wants to be changed
        }

    }
}
