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
        List<Robot> robotFleet = new List<Robot>();





        //constructor

        public Fleet()
        {

        }




        //member methods
        public void CreateFleet(Robot robot)
        {
            Robot luffy  = new Robot("Luffy",10, new Weapon("hammer" )); 
            Robot zoro = new Robot ("Zoro", 10, new Weapon("sword"));
            Robot sanji = new Robot("Sanji", 10, new Weapon("battleAx"));

            robotFleet.Add(luffy);
            robotFleet.Add(zoro);
            robotFleet.Add(sanji); 



        }
    }
}
