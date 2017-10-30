using System;

class Father
{
    public void MethodA()
    {
        Console.WriteLine("Hello from Father's MethodA");
    }
}
class Mother
{
    public void MethodA()
    {
        Console.WriteLine("Hello from Mother's MethodA");
    }
    public void MethodB()
    {
        Console.WriteLine("Hello from Mother's MethodB");
    }
    public static void MethodS() // static method
    {
        Console.WriteLine("Hello from Mother's static MethodS");
    }
    public virtual void MethodV() // virtual method
    {
        Console.WriteLine("Hello from Mother's MethodV");
    }
}
partial class Child : Father // add partial modifier
{
    public void MethodC()
    {
        Console.WriteLine("Hello from Child's MethodC");
    }
}
partial class Child : Father // contains Mother inheritance stuff
{
    private NMother base2; // NMother reference
    public Child()
    {
        base2 = new NMother();
    }
    // private nested class which inherits from Mother
    private class NMother : Mother
    {
        // overrides the virtual method Mother.MethodV
        public override void MethodV()
        {
            Console.WriteLine("Hello from Child's MethodV");
        }
    }
    // wraps Mother.MethodA but changes name to MethodD to avoid conflict with Father.MethodA
    public void MethodD()
    {
        base2.MethodA();
    }
    // wraps Mother.MethodB
    public void MethodB()
    {
        base2.MethodB();
    }
    // wraps static method Mother.MethodS
    public static void MethodS() // static method
    {
        NMother.MethodS();
    }
    // wraps override of Mother.MethodV
    public virtual void MethodV()
    {
        base2.MethodV();
    }
}
class GrandChild : Child
{
    // further overrides Mother.MethodV
    public override void MethodV()
    {
        Console.WriteLine("Hello from GrandChild's MethodV");
    }
}
class Test
{
    static void Main()
    {
        Child c = new Child();
        c.MethodA();
        c.MethodB();
        c.MethodC();
        c.MethodD();
        Child.MethodS();
        c.MethodV();
        c = new GrandChild();
        c.MethodV();
        Console.ReadKey();
    }
}