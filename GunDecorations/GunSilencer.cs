using System;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        private float suppression;

        public GunSilencer(Gun gun, float suppression) : base(gun)
        {
            if (suppression < 0 || suppression > 1f)
                throw new ArgumentOutOfRangeException(
                    "Suppression must be between 0 and 1");

            this.suppression = suppression;
        }

        public override float NoiseLevel => base.NoiseLevel * suppression;
    }
}