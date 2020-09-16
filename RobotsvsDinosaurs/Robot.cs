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
        
        public Weapon weapon;
        
        


        



        //constructor
        public Robot(string name, int powerLevel, Weapon weapon)
        {
            this.name = name;  
            this.health = 50;
            this.powerLevel = powerLevel; 
            
            this.weapon = weapon;
           
            
        }





        //member methods
        public void AttackByRobot(Dinosaur dinosaur)
        {
            dinosaur.health -= powerLevel;
        }
        public void PowerLevelDecrease()
        {
            powerLevel -= 10;
        }
    }
}
