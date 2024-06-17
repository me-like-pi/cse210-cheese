class Sphere : Circle
{
    private double _height;


    public Sphere(double r) : base (r) { }

    public override double Area()
    {
        return 4.0 * base.Area();
    }
}