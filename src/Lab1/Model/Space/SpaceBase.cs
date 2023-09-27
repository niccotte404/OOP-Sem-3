namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space;
public abstract class SpaceBase
{
    protected SpaceBase(int length)
    {
        Length = length;
    }

    public int Length { get; init; }
}
