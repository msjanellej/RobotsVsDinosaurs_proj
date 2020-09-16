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

        public List<Robot> robotFleet = new List<Robot>();
        public List<Weapon> weaponList = new List<Weapon>() { new Weapon("sword"), new Weapon("knife"), new Weapon("battleAx") };
        //public Random random = new Random();
        public Weapon weapon;





        //constructor

        public Fleet()
        {
            //Weapon weapon = new Weapon();
        }

        public void CreateFleet()
        {    // instantiate weapone
                //pass weapon into the robot.
                
                Robot luffy = new Robot("Luffy", 10, weaponList[0]);
                Robot zoro = new Robot("Zoro", 10, weaponList[1]);
                Robot sanji = new Robot("Sanji", 10, weaponList[2]);

                robotFleet.Add(luffy);
                robotFleet.Add(zoro);
                robotFleet.Add(sanji); 
        }

    }

}     
        
            
          




        //member methods

    

