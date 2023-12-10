using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FactoryFramework;

    public class InvStorage : Building, IInput
    {
        public StorageData2 data;
        public static int tech;
        
		
        private void Awake()
        {
            data.storage = new ItemStack[data.capacity];
        }


        public bool CanTakeInput(Item item)
        {
            if (item == null) return false;
            foreach (ItemStack stack in data.storage)
            {
                if (stack.item == item && stack.amount < item.itemData.maxStack) return true;
                if (stack.item == null) return true;
            }
            return false;
        }
        public void TakeInput(Item item)
        {
            for (int s = 0; s < data.storage.Length; s++)
            {
                if(tech == 0){
                    Debug.Log("tech = 0");
                    Tech01(item);
                }
                if(tech == 1){
                    Debug.Log("tech = 1");
                    Tech01(item);
                }

                ItemStack stack = data.storage[s];
                if (stack.item == item && stack.amount < item.itemData.maxStack)
                {
                    stack.amount += 1;
                    data.storage[s] = stack;
                    return;
                }
                if (stack.item == null || stack.amount == 0)
                {
                    stack.item = item;
                    stack.amount = 1;
                    data.storage[s] = stack;
                    return;
                }
            }
        }

        public void Tech01(Item item){
            if (item.itemData.description == "101"){
                Debug.Log("아이템 인식1");
            }
        }

        public void Tech02(Item item){
            if (item.itemData.description == "101"){
                Debug.Log("아이템 인식2");
            }
        }

        public static void SetTech(int t){
            tech = t;
            Debug.Log("SetTech()");
        }

    }

    [System.Serializable]
    public struct StorageData2
    {
        public string guid;
        public int capacity;
        public ItemStack[] storage;
    }
