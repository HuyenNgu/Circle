using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Circle
{
    public class Circle
    {
        private double radius;
        private string _color;
        
        public string Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        public Circle()
        {
            radius = 1.0;
            Color = "red";
        }

        public Circle(double r, string c)
        {
            radius = 1.0;
            Color = "red";
        }

        public double GetRadius()
        {
            return radius;

        }
        public double getArea1()
        {
            return 2*radius*Math.PI;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }

        //public override string ToString()
        //{
        //    return string.Format("the circle has radius of {0} and color of {1}", radius, Color);
        //}

        public override string ToString()
        {
            return string.Format("the circle has radius of {0}", radius);
        }

        public double Circumference()
        {
            return 0;
        }
    }
}
