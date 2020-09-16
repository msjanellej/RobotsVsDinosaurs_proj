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
        
        //Create weapons object here.


        



        //constructor
        public Robot(string name, int powerLevel,  int attackPower, Weapon weapon)
        {
            this.name = name;
            this.health = 50;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;
            this.weapon = weapon;
           
            
        }





        //member methods
    }
}
