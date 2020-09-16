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
        public string[] typeOfAttack;

        //constructor
        public Herd()
        {
            typeOfAttack = new string[3];
            dinoHerd = new List<Dinosaur>();
            typeOfAttack[0] = "headbutt";
            typeOfAttack[1] = "bite";
            typeOfAttack[2] = "kick";

        }

        //member methods
        public void CreateHerd()
        {
            Dinosaur trex = new Dinosaur("T-rex",  10, typeOfAttack[1] );
            Dinosaur triceratops = new Dinosaur("Triceratops", 10, typeOfAttack[0]);
            Dinosaur raptor = new Dinosaur("Raptor",  10, typeOfAttack[2]);

            dinoHerd.Add(trex);
            dinoHerd.Add(triceratops);
            dinoHerd.Add(raptor);

            

        }
    }
}
