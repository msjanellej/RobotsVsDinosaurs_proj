using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Dinosaur
    {
        //member variables
        
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        //string[] typeOfAttack = new string[3];



        //constructor
        public Dinosaur(string type,  int attackPower)
        {
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = attackPower;
        }

        //member methods
    }
}
