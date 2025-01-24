using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LSPRefactoredUnitStats{
    public class LSPRefactoredUnitStats : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

    public interface IMovable{
        public float MoveSpeed { get; set; }
        public float Acceleration{ get; set; }

        //下面两个是否需要用LSP 拆分成两个 IMovable 和 ITurnable
        public void GoForward();

        public void Reverse();

        public void TurnLeft();

        public void TurnRight();
    }

    public interface IUnitStats{
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
    }

    public interface IDamageable{
        public int Health { get; set; }
        public int Defense { get; set; }

        public void Die();
        public void TakeDamagable();

        public void RestoreHealth();
    }

    public interface IExplodable{
        public float Mass { get; set; }
        public float ExplosiveForce { get; set; }

        public float FuseDelay  { get; set; }

        public void Explode();
    }

    public class EnemyUnit: IMovable,IUnitStats,IDamageable{
        public float MoveSpeed { get; set; }
        public float Acceleration{ get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }

        public int Health { get; set; }
        public int Defense { get; set; }    

        public void GoForward(){

        }

        public void Reverse(){

        }

        public void TurnLeft(){

        }

        public void TurnRight(){

        }


        public void Die(){

        }
        public void TakeDamagable(){

        }

        public void RestoreHealth(){

        }
    }

    public class ExplodingBarrel:IDamageable,IExplodable {
        public int Health { get; set; }
        public int Defense { get; set; }  

        public float Mass { get; set; }
        public float ExplosiveForce { get; set; }
        public float FuseDelay  { get; set; }

        public void Explode(){

        }

        public void Die(){

        }
        public void TakeDamagable(){

        }

        public void RestoreHealth(){

        }
    }
}
