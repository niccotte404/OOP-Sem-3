namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class FormFactor
{
    public FormFactor(int width, int height, int depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }

    public int Width { get; init; }
    public int Height { get; init; }
    public int Depth { get; init; }
}
