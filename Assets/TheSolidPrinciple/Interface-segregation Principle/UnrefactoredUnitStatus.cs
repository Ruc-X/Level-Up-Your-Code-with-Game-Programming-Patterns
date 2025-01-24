using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnrefactoredUnitStatus{
    public class UnrefactoredUnitStatus : MonoBehaviour
    {

    }

    // interface 太冗杂复杂
    public interface IUnitStats{
        public float Health {get; set;}
        public int Defense {get;set;}

        
        public void Die();
        public void TakeDamage();
        public void RestoreHealth();


        public float MoveSpeed{get;set;}
        public float Acceleration{get;set;}

        public void GoForward();
        public void Reverse();
        public void TurnLeft();
        public void TurnRight();

        public int Strength {get;set;}
        public int Dexterity{get;set;}
        public int Endurance{get;set;}   
    }
}
