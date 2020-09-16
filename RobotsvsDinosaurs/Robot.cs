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
        public Robot(string name, int powerLevel,  int attackPower, Weapon weapon)
        {
            this.name = name;  //can I incorporate user input here in order to allow the user to pick the name of the robot.
            this.health = 50;
            this.powerLevel = powerLevel; //Can I incorportae user input here.
            this.attackPower = attackPower; // attackPower = ________ to move the attack power to the weapon
            this.weapon = weapon;
           //if I make these open to user input I could do a switch case for power level
            
        }





        //member methods
    }
}
