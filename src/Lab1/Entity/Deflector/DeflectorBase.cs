using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
internal abstract class DeflectorBase : IDeflector
{
    public bool IsPhotonDeflectorSet { get; set; }
    protected int HitPoints { get; set; }
    protected bool SetDeflector { get; set; }

    public void GetDamage<TObstacle>(TObstacle obstacle)
    {
        HitPoints -= DeflectorValidation.GetObstacle(obstacle);
    }

    public bool IsDeflectorSet()
    {
        if (SetDeflector)
        {
            if (DeflectorValidation.IsDeflectorActive(HitPoints) == false)
            {
                return false;
            }

            return true;
        }

        return false;
    }
}
