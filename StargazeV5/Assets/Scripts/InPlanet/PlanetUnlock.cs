using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetUnlock : MonoBehaviour
{
    public void UnlockMars(){
        GameManager.instance.GamePlanetUnlocked += 1;
    }
}
