using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Factory
{
        public class ProductSphere: MonoBehaviour,IProduct{
        private string _productName = "ProductSphere";
        public string productName {get =>_productName; set => _productName = value;}

        public void initialize(){
            gameObject.name = productName;
            gameObject.SetActive(true);
            Debug.Log("ProductSphere is initialized");
        }
    }
}
