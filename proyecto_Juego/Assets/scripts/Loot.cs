using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    [System.Serializable]
    public class DropCurrency
    {
        public string name;
        public GameObject item;
        public int dropRarity;
    }

    public List<DropCurrency> lootTable = new List<DropCurrency>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
