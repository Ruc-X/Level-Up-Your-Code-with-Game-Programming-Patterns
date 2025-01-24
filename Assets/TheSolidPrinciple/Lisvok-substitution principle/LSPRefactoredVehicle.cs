using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LSPRefactoredVehicle {

    public interface IMoveable {
        public void GoForward();

        public void Reverse();
    }

    public interface ITurnable {

        public void TurnLeft();


        public void TurnRight();

    }
    public class RoadVehicle: IMoveable,ITurnable {
        public void GoForward(){

        }
        public void Reverse(){

        }

        public void TurnLeft(){

        }

        public void TurnRight(){

        }
    }

    public class TrailVehicle: IMoveable {
        public void GoForward(){}
        public void Reverse(){}
    }

    public class Car: RoadVehicle {
        
    }

    public class Truck: RoadVehicle{

    }

    public class Train: TrailVehicle {

    }

}