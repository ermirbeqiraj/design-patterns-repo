namespace PatternCollection.Observer;

public interface IListener<in T>
{
    void OnChange(T value);
}
