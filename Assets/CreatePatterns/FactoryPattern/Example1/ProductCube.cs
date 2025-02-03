using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory
{
    public class ProductCube: MonoBehaviour,IProduct{
        private string _productName = "ProductCube";
        public string productName {get =>_productName; set => _productName = value;}

        public void initialize(){
            gameObject.name = productName;
            gameObject.SetActive(true);
            Debug.Log("ProductCube is initialized");
        }
    }
}
