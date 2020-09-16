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
        public List<Weapon> weaponList = new List<Weapon>() { new Weapon ("sword", 10), new Weapon("knife", 10), new Weapon("battleAx", 10) };
        
        public Weapon weapon;





        //constructor

        public Fleet()
        {
            
        }

        public void CreateFleet()
        {    
                
                Robot luffy = new Robot("Luffy",100, weaponList[0]);
                Robot zoro = new Robot("Zoro", 100, weaponList[1]);
                Robot sanji = new Robot("Sanji", 100, weaponList[2]);

                robotFleet.Add(luffy);
                robotFleet.Add(zoro);
                robotFleet.Add(sanji); 
        }

    }

}     
        
            
          




        //member methods

    

