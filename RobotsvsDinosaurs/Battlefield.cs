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
        


        //constructor
        public Battlefield()
        {

        }

        //member methods
        public void DinoAttack()
        {
            if (herd.dinoHerd.Count == 0)
            {
                DisplayWinner();
            }
           if (herd.dinoHerd.Count != 0 && fleet.robotFleet.Count != 0)
            {
                Console.WriteLine(herd.dinoHerd[0].type + " has attacked " + fleet.robotFleet[0].name);
                EnergyLevelDecrease();
                RobotHealthDecrease();
                if (fleet.robotFleet[0].health == 0)
                {
                    fleet.robotFleet.RemoveAt(0);
                }
            } 
                
            
            
            
        }
        public void RobotAttack()
        {
            if (fleet.robotFleet.Count == 0)
            {
                DisplayWinner();
            }

            if (fleet.robotFleet.Count != 0 && herd.dinoHerd.Count != 0)
            {
                Console.WriteLine(fleet.robotFleet[0].name + " has attacked " + herd.dinoHerd[0].type);
                EnergyLevelDecrease();
                DinoHealthDecrease();
                if (herd.dinoHerd[0].health == 0)
                {
                    herd.dinoHerd.RemoveAt(0);
                }

            }
        }
        public void PowerLevelDecrease()
        {
            fleet.robotFleet[0].powerLevel += -10; 
        }
        public void EnergyLevelDecrease()
        {
            herd.dinoHerd[0].energy += -10;
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
        public void  DisplayWinner()
        {
            if (fleet.robotFleet.Count == 0)
            {
                Console.WriteLine("The Dinosaurs are Victorious");
                
            }
            if (herd.dinoHerd.Count== 0)
            {
                Console.WriteLine("The Robots are Victorious");
                
            }
            
           
        }
        public bool isBattleContinuing()
        {
            if (fleet.robotFleet.Count == 0 || herd.dinoHerd.Count == 0)
            {
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

            while (isBattleContinuing() ==  true)
            {
                isBattleContinuing();
                RobotTurn();
                DinosaurTurn();
            }
           Console.ReadLine();




        }

      

    }    

    
}
