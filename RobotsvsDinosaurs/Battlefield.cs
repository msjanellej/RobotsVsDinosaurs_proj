using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Battlefield
    {
        //member variables







        //constructor
        public Battlefield()
        {

        }





        //member methods
        public void DinoAttack(Dinosaur dinosaur, Robot robot) 
        {
            Console.WriteLine(Dinosaur.dinosaur.name + " has attacked " + Robot.robot.name);
            RobotHealthDecrease(Robot robot);
        }
        public void RobotAttack(Robot robot, Dinosaur dinosaur) 
        {
            Console.WriteLine(Robot.robot.name + " has attacked " + Dinosaur.dinosaur.name);
            DinoHealthDecrease(Dinosaur dinosaur);
        }
            
        
        public void DinoHealthDecrease(Dinosaur dinosaur)
        {
            Dinosaur.dinosaur.health -= Dinosaur.dinosaur.attackPower;
        }
        public void RobotHealthDecrease(Robot robot)  //
        {
            Robot.robot.health -= Dinosaur.dinosaur.attackPower;
        }

    }
}
