using System;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }

        public void Fire()
        {
            Console.WriteLine("Ammo capacity = {0} | Noise level = {1}",
                AmmoCapacity, NoiseLevel);
        }
    }
}