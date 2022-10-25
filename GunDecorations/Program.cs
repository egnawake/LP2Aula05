using System;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Machine gun");
            Gun machineGun = new MachineGun();
            machineGun.Fire();
            Console.WriteLine("");

            Console.WriteLine("Machine gun with clip upgrade");
            Gun extraClipMachineGun = new GunClip(machineGun, 10);
            extraClipMachineGun.Fire();
            Console.WriteLine("");


            Console.WriteLine("Shotgun");
            Gun shotgun = new Shotgun();
            shotgun.Fire();
            Console.WriteLine("");

            Console.WriteLine("Shotgun with silencer");
            Gun shotgunWithSilencer = new GunSilencer(shotgun, 0.2f);
            shotgunWithSilencer.Fire();
            Console.WriteLine("");

            Console.WriteLine("Shotgun with silencer and clip");
            Gun ultraShotgun = new GunClip(shotgunWithSilencer, 6);
            ultraShotgun.Fire();
            Console.WriteLine("");
        }
    }
}
