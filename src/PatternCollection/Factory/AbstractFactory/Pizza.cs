namespace PatternCollection.Factory.AbstractFactory;

public abstract class Pizza
{
    protected Sauce? _sauce;
    public Cheese? Cheese { get; protected set; }

    public abstract void Prepare();
}
