using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J3Camera : MonoBehaviour {
    public Camera Cam;
    public GameObject Player;
    void Update()
    {
        if (MultiHowMany.Singleton.PlayerNumber == 2)
        {
            Player.SetActive(false);
        }
        if(MultiHowMany.Singleton.PlayerNumber == 3)
        {
            Cam.rect = new Rect(0.25f, 0, 0.5f, 0.5f);
        }
        if (MultiHowMany.Singleton.PlayerNumber == 4)
        {
            Cam.rect = new Rect(0, 0, 0.5f, 0.5f);
        }
    }
}
