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
        
        public Weapon weapon;





        //constructor

        public Fleet()
        {
            
        }

        public void CreateFleet()
        {    
                
                Robot luffy = new Robot("Luffy",100, 5, weaponList[0]);
                Robot zoro = new Robot("Zoro", 100,5, weaponList[1]);
                Robot sanji = new Robot("Sanji", 100,5, weaponList[2]);

                robotFleet.Add(luffy);
                robotFleet.Add(zoro);
                robotFleet.Add(sanji); 
        }

    }

}     
        
            
          




        //member methods

    

