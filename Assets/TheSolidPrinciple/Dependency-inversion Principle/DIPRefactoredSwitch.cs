using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIPRefactoredSwitch 
{
    public class DIPRefactoredSwitch : MonoBehaviour
    {
        ISwitchable client = new Door();
        
        void Toggle(){
            
            if(client.IsActivated){
                client.activated();
            }
            else{
                client.deactivated();
            }
        }
    }

    public class Door: ISwitchable{
        
        private bool isActivated = false;
        public bool IsActivated => isActivated;
        public void activated(){
            isActivated = true;
            Debug.Log("The door is opened");
        }

        public void deactivated(){
            isActivated = false;
            Debug.Log("The door is closed");
        }
    }

    public interface ISwitchable
    {
        bool IsActivated{get;}

        void activated();

        void deactivated();
    }
}
