using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KalDatabase
{
    class Weapon
    {
        public int PhysicAttack_min { get; set; }
        public int PhysicAttack_max { get; set; }
        public int MagicAttack_min { get; set; }
        public int MagicAttack_max { get; set; }
        public int HealthPoint { get; set; }
        public int ManaPoint { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Agility { get; set; }
        public int OnTargetPoint { get; set; }
        public int RequireLevel { get; set; }
    }
}
