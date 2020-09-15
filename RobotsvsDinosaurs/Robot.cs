using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Robot
    {
        //member variables
        
        public string name;
        public int health;
        public int powerLevel;
        public int attackPower;
        public Weapon weapon;



        //constructor
        public Robot(string name,  int attackPower, Weapon weapon)
        {
            this.name = name;
            this.health = 100;
            this.powerLevel = 100;
            this.attackPower = attackPower;
            this.weapon = weapon;
            
        }





        //member methods
    }
}
