class Cylinder : Circle
{
    private double _height;


    public Cylinder(double r, double h) : base (r) { _height = h; }

    public override double Area()
    {
        return 2.0 * base.Area() + 2.0 * _π * _radius * _height; 
    }
}