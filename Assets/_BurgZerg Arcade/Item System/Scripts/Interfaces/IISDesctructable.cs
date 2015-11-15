using UnityEngine;
using System.Collections;

namespace Rpg.ItemSystem.Editor
{

    public interface IISDestructable
    {
        int Durability { get; }
        int MaxDurability { get; }
        void TakeDamage(int amount);
        void Repair();
        void Break();
        
        //durability


        //takedamage

    }
}
