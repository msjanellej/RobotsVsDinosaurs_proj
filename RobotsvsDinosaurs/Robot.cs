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



        //constructor
        public Robot(string name,  int attackPower)
        {
            this.name = name;
            this.health = 100;
            this.powerLevel = 100;
            this.attackPower = attackPower;
            
        }





        //member methods
    }
}
