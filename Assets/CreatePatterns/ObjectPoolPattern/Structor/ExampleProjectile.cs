using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObjectPool{
    public class ExampleProjectile : MonoBehaviour{
        [SerializeField] private float _timeoutDelay = 3f;

        private PooledObject _pooledObject; 

        void Awake(){
            _pooledObject = GetComponent<PooledObject>();
        }
        
        public void Deactivate(){
            StartCoroutine(DeactivateRoutine(_timeoutDelay));
        }

        IEnumerator DeactivateRoutine(float delay){
            yield return new WaitForSeconds(delay);
            Rigidbody _rigidbody = _pooledObject.GetComponent<Rigidbody>();
            _rigidbody.velocity = new Vector3(0f,0f,0f);
            _rigidbody.angularVelocity = new Vector3(0f,0f,0f);

            _pooledObject.release();
            gameObject.SetActive(false);
        }
    }
}
