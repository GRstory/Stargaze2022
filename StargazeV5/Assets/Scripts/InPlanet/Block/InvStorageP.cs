using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FactoryFramework;

    public class InvStorageP : Building, IInput
    {
        public StorageData3 data;
        
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
                if(GameManager.instance.GameTechUnlocked == 0)Tech01(item);
                if(GameManager.instance.GameTechUnlocked == 1)Tech02(item);
                if(GameManager.instance.GameTechUnlocked == 2)Tech03(item);
                if(GameManager.instance.GameTechUnlocked == 3)Tech04(item);
                if(GameManager.instance.GameTechUnlocked == 4)Tech05(item);
                if(GameManager.instance.GameTechUnlocked == 5)Tech06(item);
                if(GameManager.instance.GameTechUnlocked == 6)Tech07(item);
                if(GameManager.instance.GameTechUnlocked == 7)Tech08(item);
                if(GameManager.instance.GameTechUnlocked == 8)Tech09(item);
                if(GameManager.instance.GameTechUnlocked == 9)Tech10(item);
                if(GameManager.instance.GameTechUnlocked == 10)Tech11(item);
                if(GameManager.instance.GameTechUnlocked == 11)Tech12(item);
                if(GameManager.instance.GameTechUnlocked == 12)Dyson00(item);

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
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech02(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech03(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech04(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech05(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech06(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech07(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech08(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech09(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech10(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech11(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Tech12(Item item){
            if (item.itemData.description == "301")GameManager.instance.tech01[0] += 1;
            if (item.itemData.description == "201")GameManager.instance.tech01[1] += 1;
            if (item.itemData.description == "205")GameManager.instance.tech01[2] += 1;
        }

        public void Dyson00(Item item){
            if (item.itemData.description == "502")GameManager.instance.dysonLaunch += 1;
            Debug.Log("502");
        }

    }

    [System.Serializable]
    public struct StorageData3
    {
        public string guid;
        public int capacity;
        public ItemStack[] storage;
    }
