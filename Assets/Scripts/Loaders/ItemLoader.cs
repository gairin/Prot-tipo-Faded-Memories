using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ItemLoader : MonoBehaviour {
    private string path = "Assets/GameData/ItemList.json";

    [System.Serializable]
    public class Item {
        public int id;
        public string name;
        public string fileName;
        public string description;
        public bool collected;
    }

    [System.Serializable]
    public class ItemList {
        public Item[] item;
    }

    public ItemList itemList = new ItemList();

    void Start() {
        string jsonContent = File.ReadAllText(path);
        itemList = JsonUtility.FromJson<ItemList>(jsonContent);
    }
}