using UnityEngine;
using System.Collections;
using System;

namespace Rpg.ItemSystem
{
    public class ISEquipmentSlot : IISEquipmentSlot
    {
        [SerializeField] string _name;
        
        public string Name
        {
            get { return _name; } 
            set { _name = value; }
          
        }
    }
}