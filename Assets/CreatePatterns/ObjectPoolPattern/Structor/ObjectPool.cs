using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DesignPatterns.ObjectPool{

    public class ObjectPool : MonoBehaviour{
        [SerializeField] private uint _initPoolSize;

        public uint intPoolSize => _initPoolSize;

        [SerializeField] private PooledObject  _objectToPool;

        private Stack<PooledObject> _stack;

        void Start()
        {
            setupPool();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void setupPool(){
            if(_objectToPool == null){
                return ;
            }
            _stack = new Stack<PooledObject>();
            PooledObject instance = null;
            for(int i = 0;i<_initPoolSize;i++){
                instance = Instantiate(_objectToPool);
                instance.pool = this;
                instance.gameObject.SetActive(false);
                _stack.Push(instance);
            }
        }

        public PooledObject getPooledObject(){
            if(_objectToPool == null){
                return null;
            }
            
            if(_stack.Count == 0){
                PooledObject _newInstance  = Instantiate(_objectToPool);
                _newInstance.gameObject.SetActive(true);
                _newInstance.pool = this;
                return _newInstance;
            }
            PooledObject nextInstance = _stack.Pop();
            nextInstance.gameObject.SetActive(true);
            return nextInstance;
        }

        public void returnToPool(PooledObject pooledObject){
            _stack.Push(pooledObject);
            pooledObject.gameObject.SetActive(false);
        }
    }
}
