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
        
        public string attackType;



        //constructor
        public Dinosaur(string type,  int attackPower, string attackType )
        {
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = attackPower;
            this.attackType = attackType;

        }

        //member methods
    }
}
