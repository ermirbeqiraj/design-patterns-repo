namespace PatternCollection.Factory.AbstractFactory;

public abstract record Sauce;
public abstract record Cheese;

public sealed record ChesseTypeNY : Cheese;

public sealed record SaceTypeNY : Sauce;
