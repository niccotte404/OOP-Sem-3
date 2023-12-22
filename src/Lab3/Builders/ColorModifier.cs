using System.Drawing;
using Crayon;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Builders;
public class ColorModifier : IColorModifier
{
    private readonly Color _color;
    public ColorModifier(Color color)
    {
        _color = color;
    }

    public string ModifyTextColor(string txt)
    {
        return Output.Rgb(_color.R, _color.G, _color.B).Text(txt);
    }
}
