using UnityEngine;
using System.Collections;

namespace Rpg.ItemSystem
{

    public interface IISGameObject
    {
        GameObject Prefab { get; set; }
    }
}