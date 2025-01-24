using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnrefactoredVehicle {
    public class UnrefactoredVehicle : MonoBehaviour
    {
        public float speed = 100;
        public Vector3 direction;


        public void GoForward(){

        }

        public void Reverse(){

        }


        public void TurnLeft(){

        }

        public void TurnRight(){

        }
    }

    // 满足LSP
    public class Car: UnrefactoredVehicle {
        
    }
    public class Truck: UnrefactoredVehicle {


    }


    // 违背LSP
    // TurnLeft 和 TurnRight 在Trail这个类中不被执行
    public class Trail: UnrefactoredVehicle {

    }
}
