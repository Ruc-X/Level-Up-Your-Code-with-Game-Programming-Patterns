using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 使用OCP原则，每次扩展 Shape 继承抽象类，同时实现自己面积的计算。
// AreaCalculator 只需要调用抽象类中的方法，每次扩展时不需要改动代码
namespace OCPRefactoredAreaCalculator{
    public class OCPRefactoredAreaCalculator : MonoBehaviour
    {
        // Start is called before the first frame update
        float GetArea(Shape shape){
            return shape.CalculateArea();
        }
    }

    abstract class Shape {
        public abstract float CalculateArea();
    }

    class Rectangle: Shape{
        public float width;
        public float height;

        public override float CalculateArea(){
            return width * height;
        }
    }

    class Sphere: Shape {
        public float radius;

        public override  float CalculateArea(){
            return radius * radius * Mathf.PI;
        }
    }
}
