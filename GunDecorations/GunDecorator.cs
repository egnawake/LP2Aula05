namespace GunDecorations
{
    public abstract class GunDecorator : Gun
    {
        private Gun decoratedGun;

        public GunDecorator(Gun gun)
        {
            decoratedGun = gun;
        }

        public override int AmmoCapacity => decoratedGun.AmmoCapacity;
        public override float NoiseLevel => decoratedGun.NoiseLevel;
    }
}