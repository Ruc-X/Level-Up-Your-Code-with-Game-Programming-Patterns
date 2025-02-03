using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DesignPatterns.ObjectPool
{
    public class PooledObject :MonoBehaviour
    {
        private ObjectPool _pool;
        public ObjectPool pool {get=>_pool;set => _pool = value;}

        public void release(){
            _pool.returnToPool(this);
        }
    }
}