using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Lesson
{
    class Character
    {
        //public int Health
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //        health = value;
        //    }
        //}
        public int Health { get; private set; } = 100;

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            Health -= damage;
        }
        
    }
}
