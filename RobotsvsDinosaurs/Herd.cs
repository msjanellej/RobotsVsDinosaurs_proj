using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
     public class Herd
    {
        //member variables
        public List<Dinosaur> dinoHerd;
        public string[] typeOfAttack = new string[3];





        //constructor
        public Herd()
        {
            dinoHerd = new List<Dinosaur>();
            typeOfAttack[0] = "headbutt";
            typeOfAttack[1] = "bite";
            typeOfAttack[2] = "kick";

        }





        //member methods
        public void CreateHerd()
        {
            Dinosaur trex = new Dinosaur("trex",  5, typeOfAttack[1] );
            Dinosaur triceratops = new Dinosaur("triceratops", 5, typeOfAttack[0]);
            Dinosaur raptor = new Dinosaur("raptor",  5, typeOfAttack[2]);

            dinoHerd.Add(trex);
            dinoHerd.Add(triceratops);
            dinoHerd.Add(raptor);

            

        }
    }
}
