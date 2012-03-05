using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Immunemask_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "mechanic_immune_mask Calculator written by Invisible © 2012";

            string immunemasks;

            Console.Write("Add meg az immunemaskot: ");
            immunemasks = Console.ReadLine();

            Calculator(immunemasks);

            Console.ReadLine();

        }

        static bool IsInt(string intlesz)
        {
            bool sztemint = false;
            try
            {
                int.Parse(intlesz);
                sztemint = true;
            }
            catch { }
            return sztemint;
        }

        static void Calculator(string immunemasks)
        {
            if (IsInt(immunemasks))
            {
                int immunemask, i = 0;
                bool vege = true;
                immunemask = Convert.ToInt32(immunemasks);
                while (vege || i == 31)
                {
                    if (immunemask >= 1073741824)
                    {
                        Console.WriteLine("1073741824	 0x4000 0000	 MECHANIC_ENRAGED");
                        immunemask = immunemask - 1073741824;
                    }
                    else if(immunemask >= 536870912)
                    {
                        Console.WriteLine("536870912	 0x2000 0000	 MECHANIC_SAPPED");
                        immunemask = immunemask - 536870912;
                    }
                    else if (immunemask >= 268435456)
                    {
                        Console.WriteLine("268435456	 0x1000 0000	 MECHANIC_IMMUNE_SHIELD	 Divine Shield, Ice Block, Hand of Protection...");
                        immunemask = immunemask - 268435456;
                    }
                    else if (immunemask >= 134217728)
                    {
                        Console.WriteLine("134217728	 0x0800 0000	 MECHANIC_DISCOVERY	 Any Create Item effect");
                        immunemask = immunemask - 134217728;
                    }
                    else if (immunemask >= 67108864)
                    {
                        Console.WriteLine("67108864	 0x0400 0000	 MECHANIC_DAZE");
                        immunemask = immunemask - 67108864;
                    }
                    else if (immunemask >= 33554432)
                    {
                        Console.WriteLine("33554432	 0x0200 0000	 MECHANIC_INTERRUPT");
                        immunemask = immunemask - 33554432;
                    }
                    else if (immunemask >= 16777216)
                    {
                        Console.WriteLine("16777216	 0x0100 0000	 MECHANIC_INVULNERABILITY	 Forbearance, Nether Protection, Diplomatic Immunity only");
                        immunemask = immunemask - 16777216;
                    }
                    else if (immunemask >= 8388608)
                    {
                        Console.WriteLine("8388608	 0x0080 0000	 MECHANIC_HORROR	 e.g. Death Coil (Warlock)");
                        immunemask = immunemask - 8388608;
                    }
                    else if (immunemask >= 4194304)
                    {
                        Console.WriteLine("4194304	 0x0040 0000	 MECHANIC_TURN	 e.g. Turn Evil");
                        immunemask = immunemask - 4194304;
                    }
                    else if (immunemask >= 2097152)
                    {
                        Console.WriteLine("2097152	 0x0020 0000	 MECHANIC_INFECTED	 Frost Fever, Blood Plague etc.");
                        immunemask = immunemask - 2097152;
                    }
                    else if (immunemask >= 1048576)
                    {
                        Console.WriteLine("1048576	 0x0010 0000	 MECHANIC_MOUNT	 Any effect that summons a mount");
                        immunemask = immunemask - 1048576;
                    }
                    else if (immunemask >= 524288)
                    {
                        Console.WriteLine("524288	 0x0008 0000	 MECHANIC_SHACKLE	 Shackle Undead only");
                        immunemask = immunemask - 524288;
                    }
                    else if (immunemask >= 262144)
                    {
                        Console.WriteLine("262144	 0x0004 0000	 MECHANIC_SHIELD");
                        immunemask = immunemask - 262144;
                    }
                    else if (immunemask >= 131072)
                    {
                        Console.WriteLine("131072	 0x0002 0000	 MECHANIC_BANISH");
                        immunemask = immunemask - 131072;
                    }
                    else if (immunemask >= 65536)
                    {
                        Console.WriteLine("65536	 0x0001 0000	 MECHANIC_POLYMORPH");
                        immunemask = immunemask - 65536;
                    }
                    else if (immunemask >= 32768)
                    {
                        Console.WriteLine("32768	 0x0000 8000	 MECHANIC_BANDAGE	 Healing etc.");
                        immunemask = immunemask - 32768;
                    }
                    else if (immunemask >= 16384)
                    {
                        Console.WriteLine("16384	 0x0000 4000	 MECHANIC_BLEED");
                        immunemask = immunemask - 16384;
                    }
                    else if (immunemask >= 8192)
                    {
                        Console.WriteLine("8192	 0x0000 2000	 MECHANIC_KNOCKOUT	 Incapacitate effects such as Repetance (Paladin)");
                        immunemask = immunemask - 8192;
                    }
                    else if (immunemask >= 4096)
                    {
                        Console.WriteLine("4096	 0x0000 1000	 MECHANIC_FREEZE	");
                        immunemask = immunemask - 4096;
                    }
                    else if (immunemask >= 2048)
                    {
                        Console.WriteLine("2048	 0x0000 0800	 MECHANIC_STUN");
                        immunemask = immunemask - 2048;
                    }
                    else if (immunemask >= 1024)
                    {
                        Console.WriteLine("1024	 0x0000 0400	 MECHANIC_SNARE");
                        immunemask = immunemask - 1024;
                    }
                    else if (immunemask >= 512)
                    {
                        Console.WriteLine("512	 0x0000 0200	 MECHANIC_SLEEP");
                        immunemask = immunemask - 512;
                    }
                    else if (immunemask >= 256)
                    {
                        Console.WriteLine("256	 0x0000 0100	 MECHANIC_SILENCE");
                        immunemask = immunemask - 256;
                    }
                    else if (immunemask >= 128)
                    {
                        Console.WriteLine("128	 0x0000 0080	 MECHANIC_PACIFY	 Not used: 0 spells with this mechanic");
                        immunemask = immunemask - 128;
                    }
                    else if (immunemask >= 64)
                    {
                        Console.WriteLine("64	 0x0000 0040	 MECHANIC_ROOTP");
                        immunemask = immunemask - 64;
                    }
                    else if (immunemask >= 32)
                    {
                        Console.WriteLine("32	 0x0000 0020	 MECHANIC_GRIP	 Death Grip and similar effects");
                        immunemask = immunemask - 32;
                    }
                    else if (immunemask >= 16)
                    {
                        Console.WriteLine("16	 0x0000 0010	 MECHANIC_FEAR");
                        immunemask = immunemask - 16;
                    }
                    else if (immunemask >= 8)
                    {
                        Console.WriteLine("8	 0x0000 0008	 MECHANIC_DISTRACT");
                        immunemask = immunemask - 8;
                    }
                    else if (immunemask >= 4)
                    {
                        Console.WriteLine("4	 0x0000 0004	 MECHANIC_DISARM");
                        immunemask = immunemask - 4;
                    }
                    else if (immunemask >= 2)
                    {
                        Console.WriteLine("2	 0x0000 0002	 MECHANIC_DISORIENTED");
                        immunemask = immunemask - 2;
                    }
                    else if (immunemask >= 1)
                    {
                        Console.WriteLine("1	 0x0000 0001	 MECHANIC_CHARM");
                        immunemask = immunemask - 1;
                    }
                    else if (immunemask == 0)
                    {
                        vege = false;
                    }
                    i++;
                }
                return;
            }
            else
                Console.WriteLine("Egy számot adj meg!");
        }
    }
}
