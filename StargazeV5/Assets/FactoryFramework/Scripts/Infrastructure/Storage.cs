using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FactoryFramework
{
    public class Storage : Building, IInput, IOutput
    {
        public StorageData data;
        public GameObject objectInventoryUI;
        //public TextMeshProUGUI inventoryText;
        public Text inventoryText;
		
        private void Awake()
        {
            data.storage = new ItemStack[data.capacity];
        }

        private void Update() {
            UpdateUI();
        }

        private void OnMouseDown() {
            ShowUI();
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

        public bool CanGiveOutput(Item filter = null)
        {
            foreach (ItemStack stack in data.storage)
            {
                if ((filter != null && stack.item == filter || stack.item != null) && stack.amount > 0) return true;
            }
            return false;
        }
        public Item OutputType()
        {
            foreach (ItemStack stack in data.storage)
            {
                if (stack.item == null && stack.amount > 0) return stack.item;
            }
            return null;
        }
        public Item GiveOutput(Item filter = null)
        {
            for (int s = 0; s < data.storage.Length; s++)
            {
                ItemStack stack = data.storage[s];
                if (stack.item == null) continue;
                if ((filter != null && stack.item == filter || stack.item != null) && stack.amount > 0)
                {
                    stack.amount -= 1;
                    Item item = stack.item;
                    data.storage[s] = stack;
                    return item;
                }
            }
            return null;
        }

        public void ShowUI(){
            objectInventoryUI.SetActive(true);
        }

        public void UpdateUI(){
            string mainText = "";

            for (int i = 0; i < 10; i++){
                string text = data.storage[i].amount.ToString();
				
                mainText = mainText + data.storage[i].item + text + "\n";
            }

            inventoryText.text = mainText;
        }
    }
    [System.Serializable]
    public struct StorageData
    {
        public string guid;
        public int capacity;
        public ItemStack[] storage;
    }
}