namespace Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;
internal static class DeflectorValidation
{
    public static bool IsDeflectorActive(int getAmount)
    {
        return getAmount >= 0;
    }
}
