using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}
public struct Dog
{
    public Dog (string Name, float Age, string Owner, Rating Rating)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rating;
    }
    public string name {get; set;}
    public float age {get; set;}
    public string owner {get; set;}
    public Rating rating {get; set;}
}