using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory
{
    public class FactoryPatternController : MonoBehaviour
    {
        [SerializeField] FactorySphere  factorySphere;
        [SerializeField] FactoryCube factoryCube;
        // Start is called before the first frame update
        void Start()
        {
            //    factorySphere = GetComponent<FactorySphere>();
            //    factoryCube = GetComponent<FactoryCube>();
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0)){
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 10;
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                IProduct product = factorySphere.getProduct(worldPosition);
                product.initialize();
            }
            else if(Input.GetMouseButtonDown(1)){
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 10;
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                IProduct product = factoryCube.getProduct(worldPosition);
                product.initialize();
            }
        }
    }
}
