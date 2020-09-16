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
            else if (herd.dinoHerd[0].energy == 0)
            {
                herd.dinoHerd.RemoveAt(0);
            }          
           else if (herd.dinoHerd.Count != 0 && fleet.robotFleet.Count != 0)
            {
                Console.WriteLine(herd.dinoHerd[0].type + " has attacked " + fleet.robotFleet[0].name +" with a " + herd.dinoHerd[0].attackType);
                herd.dinoHerd[0].AttackByDino(fleet.robotFleet[0]);
                herd.dinoHerd[0].EnergyLevelDecrease();
                Console.WriteLine(herd.dinoHerd[0].type + "'s energy has decreased to " + herd.dinoHerd[0].energy);
                Console.WriteLine(" ");
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
            else if (fleet.robotFleet[0].powerLevel == 0)
            {
                fleet.robotFleet.RemoveAt(0);
            }
            else if (fleet.robotFleet.Count != 0 && herd.dinoHerd.Count != 0)
            {
                Console.WriteLine(fleet.robotFleet[0].name + " has attacked " + herd.dinoHerd[0].type + " with a " + fleet.robotFleet[0].weapon.type);
                fleet.robotFleet[0].AttackByRobot(herd.dinoHerd[0]);
                fleet.robotFleet[0].PowerLevelDecrease();
                Console.WriteLine(fleet.robotFleet[0].name + "'s power level has decreased to " + fleet.robotFleet[0].powerLevel);
                Console.WriteLine();
                if (herd.dinoHerd[0].health == 0)
                {
                    herd.dinoHerd.RemoveAt(0);
                }

            }
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
                Console.WriteLine("The Dinosaurs are Victorious!!!!!");
                
            }
            if (herd.dinoHerd.Count== 0)
            {
                Console.WriteLine("The Robots are Victorious!!!!!");
                
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

            while (isBattleContinuing())
            {
                
                RobotTurn();
                DinosaurTurn();
            }
           Console.ReadLine();




        }

      

    }    

    
}
