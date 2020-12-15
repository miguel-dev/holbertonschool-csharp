using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}
public struct Dog
{
    public string name {get; set;}
    public float age {get; set;}
    public string owner {get; set;}
    public Rating rating {get; set;}
}