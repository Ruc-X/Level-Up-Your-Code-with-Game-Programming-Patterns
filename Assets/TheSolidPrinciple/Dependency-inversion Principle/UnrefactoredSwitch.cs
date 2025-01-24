using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnrefactoredSwitch {
    public class UnrefactoredSwitch : MonoBehaviour
    {
        bool isAcitated = false;
        Door door1 = new Door();
        void Toggle(){
            if (isAcitated){
                isAcitated = false;
                door1.open();
            }
            else{
                isAcitated = true;
                door1.close();
            }
        }
    }   


    public class Door
    {
        public void open(){

        }

        public void close(){

        }
    }
}