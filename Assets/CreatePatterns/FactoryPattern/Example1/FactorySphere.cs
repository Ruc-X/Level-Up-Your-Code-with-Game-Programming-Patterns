using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory{
    public class FactorySphere: Factory
    {
        [SerializeField] private GameObject _spherePrefab;
        public override IProduct getProduct(Vector3 position){
            GameObject instance = Instantiate(_spherePrefab, position, Quaternion.identity);
            IProduct sphereProduct = instance.GetComponent<ProductSphere>();
            return sphereProduct;
        }
    }
}
