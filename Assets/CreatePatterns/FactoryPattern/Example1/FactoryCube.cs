using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DesignPatterns.Factory
{
    public class FactoryCube: Factory{
        [SerializeField] private GameObject _cubePrefab;
        public override IProduct getProduct(Vector3 position){
            GameObject instance = Instantiate(_cubePrefab, position, Quaternion.identity);
            IProduct cubeProduct = instance.GetComponent<ProductCube>();
            return cubeProduct;
        }
    }
}
