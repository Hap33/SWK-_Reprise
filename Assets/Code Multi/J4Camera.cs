using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J4Camera : MonoBehaviour {

    public Camera Cam;
    public GameObject Player;

    private void Start()
    {
        Player.SetActive(true);
    }

    private void Update()
    {
        if (MultiHowMany.Singleton.PlayerNumber != 4)
        {
            Player.SetActive(false);
        }
        if (MultiHowMany.Singleton.PlayerNumber == 4)
        {
            Cam.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
        }
    }
}
