using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class ThirdClass : DeflectorBase
{
    private List<int> _getDamageAmount;
    public ThirdClass(bool setDeflector, bool setPhotodDeflector)
    {
        SetDeflector = setDeflector;
        IsPhotonDeflectorSet = setPhotodDeflector;
        GetAsterodAmount = 40;
        GetMetheoritAmount = 10;
        GetSpaceWhaleAmount = 1;
        SetAntimaterAmount();
        _getDamageAmount = new List<int>() { GetAsterodAmount, GetMetheoritAmount, GetSpaceWhaleAmount, GetAnthimaterAmount };
    }

    public override bool IsDeflectorSet()
    {
        if (SetDeflector)
        {
            foreach (int elem in _getDamageAmount)
            {
                if (DeflectorValidation.IsDeflectorActive(elem) == false)
                {
                    return false;
                }
            }

            return true;
        }

        return false;
    }

    private void SetAntimaterAmount()
    {
        if (IsPhotonDeflectorSet)
        {
            GetAnthimaterAmount = 3;
        }
        else
        {
            GetAnthimaterAmount = 0;
        }
    }
}