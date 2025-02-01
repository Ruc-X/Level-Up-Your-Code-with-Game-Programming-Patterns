using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace DesignPattern.Factory
{

    public interface IProduct{
        public string productName{get; set;}
        public void initialize();
    }

    // public class ProductA: MonoBehaviour,IProduct {
    //     [SerializeField] private string _productName = "ProductA";
    //     public string productName {get => _productName;set => _productName = value;}

    //     private ParticleSystem _particleSystem;
        
    //     public void initialize(){
    //         Debug.Log("ProductA is initialized");
    //     }
    // }

    public abstract class Factory: MonoBehaviour {
        public abstract IProduct getProduct(Vector3 position);
        
    }

    // public class ConcreteFactoryA: Factory{

    //     public override IProduct getProduct(Vector3 position)
    //     {
    //         IProduct newProduct = new ProductA();
    //         newProduct.initialize();
    //         Debug.Log("Create a new ProductA in ConcreteFactoryA");
    //         return newProduct;
    //     }
    // }
}
