    using UnityEngine;
using System;

public class GameManager:MonoBehaviour
{
    public struct TechData
    {
        public int item01;
        public int item02;
        public int item03;
    }


    public static GameManager instance;
    public static Action target;
    public int GamePlanetUnlocked = 1;
    public int GameTechUnlocked = 0;
    public int GameDysonStatus = 0;
    public int GameSeed1 = 0;
    public int GameSeed2 = 1;
    public int GameSeed3 = 2;
    public float GameOffetX = 0.0f;
    public float GameOffetY = 0.0f;
    public bool IsGameStart = false;
    public int[] tech01 = {0, 0, 0};
    public int[] tech02 = {0, 0, 0};
    public int[] tech03 = {0, 0, 0};
    public int[] tech04 = {0, 0, 0};
    public int[] tech05 = {0, 0, 0};
    public int[] tech06 = {0, 0, 0};
    public int[] tech07 = {0, 0, 0};
    public int[] tech08 = {0, 0, 0};
    public int[] tech09 = {0, 0, 0};
    public int[] tech10 = {0, 0, 0};
    public int[] tech11 = {0, 0, 0};
    public int[] tech12 = {0, 0, 0};

    private int[] tech01Base = {50, 50, 50};
    private int[] tech02Base = {100, 50, 50};
    private int[] tech03Base = {150, 100, 100};
    private int[] tech04Base = {200, 200, 200};
    private int[] tech05Base = {50, 50, 50};
    private int[] tech06Base = {100, 50, 100};
    private int[] tech07Base = {150, 100, 100};
    private int[] tech08Base = {200, 200, 200};
    private int[] tech09Base = {50, 100, 100};
    private int[] tech10Base = {100, 100, 0};
    private int[] tech11Base = {150, 150, 0};
    private int[] tech12Base = {200, 200, 200};
    public int[] techBaseData = {50, 50, 50, 100, 50, 50, 150, 100, 100, 200, 200, 200, 50, 50, 50, 100, 50, 100, 150, 100, 100, 200, 200, 200, 50, 100, 100, 100, 100, 0, 150, 150, 0, 200, 200, 200};
    
    public int dysonLaunch = 0;
    public int dysonBaseData = 10;

    public static GameManager Instance{
        get{
            if(!instance){
                instance = FindObjectOfType(typeof(GameManager)) as GameManager;
                if(instance == null){
                    Debug.Log("Game Manager Null");
                }
            }
            return instance;
        }
    }

    private void Awake() {
        if(instance == null){
            instance = this;
        }
        else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void GameUpdate(){
        Debug.Log("GamePlanetUnlocked: "+ GamePlanetUnlocked);
        Debug.Log("GameResearchUnlocked: "+ GameTechUnlocked);
        Debug.Log("GameDysonStatus: "+ GameDysonStatus);

        if(GameDysonStatus == 100){
            Debug.Log("Dyson Complete");
        }
    }

    public static void SetTech01(int num1, int num2, int num3){
        GameManager.instance.tech01[0] = num1;
        GameManager.instance.tech01[1] = num2;
        GameManager.instance.tech01[2] = num3;
    }

    private void Update() {
        for(int i = 0; i < 3; i++){
            if(tech01[i] > tech01Base[i]){
                tech01[i] = tech01Base[i];
            }
            if(tech02[i] > tech02Base[i]){
                tech02[i] = tech02Base[i];
            }
            if(tech03[i] > tech03Base[i]){
                tech03[i] = tech03Base[i];
            }
            if(tech04[i] > tech04Base[i]){
                tech04[i] = tech04Base[i];
            }
            if(tech05[i] > tech05Base[i]){
                tech05[i] = tech05Base[i];
            }
            if(tech06[i] > tech06Base[i]){
                tech06[i] = tech06Base[i];
            }
            if(tech07[i] > tech07Base[i]){
                tech07[i] = tech07Base[i];
            }
            if(tech08[i] > tech08Base[i]){
                tech08[i] = tech08Base[i];
            }
            if(tech09[i] > tech09Base[i]){
                tech09[i] = tech09Base[i];
            }
            if(tech10[i] > tech10Base[i]){
                tech10[i] = tech10Base[i];
            }
            if(tech11[i] > tech11Base[i]){
                tech11[i] = tech11Base[i];
            }
            if(tech12[i] > tech12Base[i]){
                tech12[i] = tech12Base[i];
            }
            if(dysonLaunch > dysonBaseData){
                dysonLaunch = dysonBaseData;
            }
        }
    }
}