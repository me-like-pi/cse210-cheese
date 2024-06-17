using System.Runtime.InteropServices;

class Circle : RoundShape
{
    protected double _radius;
    protected double _π = Math.PI;
 
    public Circle(double r) {_radius = r;}
    public override double Area()
    {
        return  _π * _radius * _radius;
    }
}