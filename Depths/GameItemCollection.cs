using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depths
{
    public class GameItemCollection
    {
        

       List<Weapon> lowLevelWeapons = new List<Weapon>()
       {
           new Weapon(){Name ="Iron Dagger", Type ="Dagger", Description ="A small cheap dagger", Weight= 1, Value = 3, WeaponDamage = 2 , WeaponSpeed =10},
           new Weapon(){Name ="Iron ShortSword", Type ="Shortsword", Description ="A cheap stunted sword", Weight= 2, Value =5 , WeaponDamage =3 , WeaponSpeed =8},
           new Weapon(){Name ="Iron LongSword", Type ="Longsword", Description ="A cheap longsword", Weight= 3, Value = 6, WeaponDamage =5 , WeaponSpeed =6},
           new Weapon(){Name ="Iron Hammer", Type ="Hammer", Description ="A rusty iron ball attatched to a wooden handle", Weight= 6, Value = 6, WeaponDamage = 8, WeaponSpeed = 4},
           new Weapon(){Name ="Iron Axe", Type ="Axe", Description ="A heavy iron axe", Weight= 5, Value = 5, WeaponDamage = 7, WeaponSpeed = 5},
           new Weapon(){Name ="Fine Iron Dagger", Type ="Dagger", Description ="A decent dagger", Weight= 1, Value = 4, WeaponDamage = 3 , WeaponSpeed =10},
           new Weapon(){Name ="Fine Iron ShortSword", Type ="Shortsword", Description ="A decent short sword", Weight= 2, Value =7 , WeaponDamage =4 , WeaponSpeed =8},
           new Weapon(){Name ="Fine Iron LongSword", Type ="Longsword", Description ="A fine longsword", Weight= 3, Value = 8, WeaponDamage =6 , WeaponSpeed =6},
           new Weapon(){Name ="Fine Iron Hammer", Type ="Hammer", Description ="A polished iron ball attatched to a oak handle", Weight= 6, Value = 8, WeaponDamage = 9, WeaponSpeed = 4},
           new Weapon(){Name ="Fine Iron Axe", Type ="Axe", Description ="A engraved iron axe", Weight= 5, Value = 7, WeaponDamage = 8, WeaponSpeed = 5},
       };

        List<Weapon> MidLevelWeapons = new List<Weapon>()
       {
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},

       };

        List<Weapon> HighLevelWeapons = new List<Weapon>()
       {
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},

       };

        List<Weapon> SpecialWeapons = new List<Weapon>()
       {
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},
           new Weapon(){Name ="", Type ="", Description ="", Weight= , Value = , WeaponDamage = , WeaponSpeed =},

       };
    }
}
