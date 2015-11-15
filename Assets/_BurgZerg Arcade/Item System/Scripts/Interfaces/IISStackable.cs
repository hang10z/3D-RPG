using UnityEngine;
using System.Collections;

namespace Rpg.ItemSystem
{

    public interface IISStackable
    {
        int Stack(int amount);
        int MaxStack { get; }

       
    }
}
