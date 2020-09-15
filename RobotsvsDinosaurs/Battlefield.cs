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
        Fleet fleet = new Fleet();
        Herd herd = new Herd();
        bool isBattleContinuing = true;


        //constructor
        public Battlefield()
        {

        }

        //member methods
        public void DinoAttack()
        {
            Console.WriteLine(herd.dinoHerd[0].type + " has attacked " + fleet.robotFleet[0].name);
            Console.ReadLine();
            RobotHealthDecrease();
            if (fleet.robotFleet[0].health == 0)
            {
                fleet.robotFleet.RemoveAt(0);
            }
            if (herd.dinoHerd[0].health == 0)
            {
                DisplayWinner();
            }
        }
        public void RobotAttack()
        {
            Console.WriteLine(fleet.robotFleet[0].name + " has attacked " + herd.dinoHerd[0].type);
            Console.ReadLine();
            DinoHealthDecrease();
            if (herd.dinoHerd[0].health == 0)
            {
                herd.dinoHerd.RemoveAt(0);
            }
            if (fleet.robotFleet[0].health == 0);
            {
                DisplayWinner();
            }
        }


        public void DinoHealthDecrease()
        {
            herd.dinoHerd[0].health -= fleet.robotFleet[0].attackPower;
        }
        public void RobotHealthDecrease()  
        {
            fleet.robotFleet[0].health -= herd.dinoHerd[0].attackPower;
        }
        public void RobotTurn()
        {
            RobotAttack();
        }
        public void DinosaurTurn()
        {
            DinoAttack();
        }
        public bool DisplayWinner()
        {
            if (fleet.robotFleet[0] == null)
            {
                Console.WriteLine("The Dinosaurs are Victorious");
                return false;
                
            }
            if (herd.dinoHerd[0] == null)
            {
                Console.WriteLine("The Robots are Victorious");
                return false;
                
            }
            else
            {
                return true;
            }
           
        }
        

        public void RunBattle()
        {
            herd.CreateHerd();
            fleet.CreateFleet();
            
           while (isBattleContinuing ==  true)
            {
                
                RobotTurn();
                DinosaurTurn();
            }
            




        }

      

    }    

    
}
