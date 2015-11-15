using UnityEngine;
using System.Collections;

namespace Rpg.ItemSystem
{

    public interface ISSEquipable 
    {
        ISEquipmentSlot EquipmentSlot { get; }
        bool Equip();
        //Test
    }
}
