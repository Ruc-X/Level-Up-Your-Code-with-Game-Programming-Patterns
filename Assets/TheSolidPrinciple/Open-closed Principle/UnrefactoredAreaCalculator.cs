using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// 不方便扩展每次扩展都需要改动 AreaCalculator 的代码
namespace UnrefactoredAreaCalculator{
    public class UnrefactoredAreaCalculator : MonoBehaviour
    {
        float getSphereArea(Circle circle){
            return circle.radius * circle.radius * Mathf.PI;
        } 

        float getRectangleArea(Rectangle rectangle){
            return rectangle.width * rectangle.height;
        }
    }


    class Circle {
        public float radius;
    }

    class Rectangle {
        public float width;
        public float height;
    }
}