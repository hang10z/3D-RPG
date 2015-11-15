using UnityEngine;
using System.Collections;


namespace Rpg.ItemSystem {

    public interface IISObject
    {


        //Name of the item
        string Name { get; set; }

        //How much the item is worth in gold
        int Value { get; set; }

        //Icon or Sprite in inventory
        Sprite Icon { get; set; }

        //Burden of the item (how much it weighs
        int Burden { get; set; }

        //Quality Level of the Item (Common, Rare, Etc)
        ISQuality Quality { get; set; }
    }



    //equip
    //questItem flag
    

}
