using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponGame
{
    internal class Weapon
    {
        private int _maxAmmoCapacity = 40;

        public Weapon()
        {
            _currentAmmoCapacity = _maxAmmoCapacity;
        }
        public int MaxAmmoCapacity
        {
            get
            {
                return _maxAmmoCapacity;
            }
            set
            {
                _maxAmmoCapacity = value;
            }
        }

        private int _currentAmmoCapacity;
        public int CurrentAmmoCapacity
        {
            get
            {
                return _currentAmmoCapacity;
            }
            set
            {
                _currentAmmoCapacity = value;
            }
        }

        public string Mode { get; set; } = "single";
        public void Shoot()
        {
            if (_currentAmmoCapacity > 0)
            {
                _currentAmmoCapacity--;
                Console.WriteLine("The rifle has shot 1 round.");
            }
            else
            {
                Console.WriteLine("Out of ammo! Reload required.");
            }
        }
        public void Fire()
        {
            if (Mode == "auto")
            {
                if (_currentAmmoCapacity > 0)
                {
                    Console.WriteLine($"The rifle has shot {_currentAmmoCapacity} rounds.");
                    _currentAmmoCapacity = 0;
                }
                else
                {
                    Console.WriteLine("You have already emptied your magazine. Reload required!");
                }
            } else
            {
                Console.WriteLine("Your mode is on single.");
                Shoot();
            }
        }
        public int GetRemainBulletCount()
        {
            return _maxAmmoCapacity - _currentAmmoCapacity;
        }
        public void Reload()
        {
            if (_currentAmmoCapacity<=0)
            {
                _currentAmmoCapacity = _maxAmmoCapacity;
                Console.WriteLine("Magazine reloaded.");
            } else
            {
                Console.WriteLine("You still have left bullets in magazine.");
            }
        }
        public void ChangeFireMode()
        {
            if (Mode == "single")
            {
                Mode = "auto";
                Console.WriteLine("Change mode to auto.");
            }
            else
            {
                Mode = "single";
                Console.WriteLine("Changed mode to single");
            }
        }
    }
}
