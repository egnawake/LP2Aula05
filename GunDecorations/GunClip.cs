namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        private int clipIncrement;

        public GunClip(Gun gun, int clipIncrement) : base(gun)
        {
            this.clipIncrement = clipIncrement;
        }

        public override int AmmoCapacity => base.AmmoCapacity + clipIncrement;
    }
}