using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveData{
    public string saveName;
    public int planetProgress = 1; //행성 진행도
    public int sunProgress = 0; //태양 다이슨구체 진행도
    public int seedEarth = 20; //지구 시드
    public int seedMars = 40; //화성 시드
    public int seedMercury = 60; //수성 시드
    public bool musicOn = true; //설정-노래
}

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;

    public SaveData nowData = new SaveData();
    public string path;
    public int slotNum;
    private void Awake() {
        if(instance == null){
            instance = this;
        }
        else{
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        Debug.Log(path);
    }
    public void SaveData(){
        string data = JsonUtility.ToJson(nowData);
        File.WriteAllText(path + slotNum.ToString(), data);
    }
    public void LoadData(){
        string data = File.ReadAllText(path + slotNum.ToString());
        nowData = JsonUtility.FromJson<SaveData>(data);
    }
    public void DeleteData(){
        slotNum -= 1;
        nowData = new SaveData();
    }
}
