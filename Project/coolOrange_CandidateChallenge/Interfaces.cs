using System;

interface IPriority
{
    final int MIN_PRIORITY = 1;
    final int MED_PRIORITY = 5; //Warum?
    final int MAX_PRIORITY = 10;
    public void SetPriority(int priority);
    public int GetPriority();
}

interface ICompexity
{
    public void SetCompexity(int priority);
    public int GetComplexity();
}