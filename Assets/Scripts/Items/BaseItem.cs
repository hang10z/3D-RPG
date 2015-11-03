using UnityEngine;
using System.Collections;

public class BaseItem
{

    private string itemName;
    private string itemDescription;
    private int itemID;

    public enum ItemTypes
    {
        //TODO: BaseItem: NEED TO FINISH ALL ITEM TYPES
        ARMOR,
        WEAPON,
        SCROLL,
        CONSUME,
        CHEST
    }

    private ItemTypes itemType;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public int ItemId
    {
        get { return itemID; }
        set { itemID = value; }
    }

    public ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}

	
