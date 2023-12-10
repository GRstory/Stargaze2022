using UnityEngine;

public class PlanetSpin : MonoBehaviour
{
    public GameObject planet;
    public float speed;

    //Planet 별 거리 데이터
    //Planet_Mercury: 2.2
    //Planet_Venus  : 3.5
    //Planet_Earth  : 5.0
    //Planet_Mars   : 7.0

    //Planet 별 속도 데이터
    //Planet_Mercury: 41.6
    //Planet_Venus  : 16.0
    //Planet_Earth  : 10.0
    //Planet_Mars   : 5.55

    // Update is called once per frame
    void Update()
    {
        Spin();
    }

    void Spin()
    {
        transform.RotateAround(planet.transform.position, Vector3.forward, speed*Time.deltaTime);
    }
}
