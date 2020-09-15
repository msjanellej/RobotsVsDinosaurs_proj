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





        //constructor
        public Herd()
        {
            dinoHerd = new List<Dinosaur>();

        }





        //member methods
        public void CreateHerd(Dinosaur dinosaur)
        {
            Dinosaur trex = new Dinosaur("trex",  10);
            Dinosaur triceratops = new Dinosaur("triceratops", 10);
            Dinosaur raptor = new Dinosaur("raptor",  10);

            dinoHerd.Add(trex);
            dinoHerd.Add(triceratops);
            dinoHerd.Add(raptor);

        }
    }
}
