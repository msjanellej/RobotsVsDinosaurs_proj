using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Fleet
    {
        //member variables
        List<string> robotFleet = new List<string>;





        //constructor

        public Fleet()
        {

        }




        //member methods
        public void CreateFleet(Robot robot)
        {
            Robot robotOne  = new Robot("Luffy",10);
            Robot robotTwo = new Robot ("Zoro", 10);
            Dinosaur robotThree = new Dinosaur("Sanji", 10);

            robotFleet.Add(robotOne);
            robotFleet.Add(robotTwo);
            robotFleet.Add(robotThree);



        }
    }
}
