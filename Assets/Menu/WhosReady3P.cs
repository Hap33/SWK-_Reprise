﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhosReady3P : MonoBehaviour {

    public static int NumberOfReady = 0;
    private void Awake()
    {
        NumberOfReady = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (NumberOfReady == 3)
        {
            if (MultiHowMany.Singleton.MapCategory == 1)
            {
                SceneManager.LoadScene("Map1Play");
            }
            if (MultiHowMany.Singleton.MapCategory == 2)
            {
                SceneManager.LoadScene("map_2");
            }
            MultiHowMany.Singleton.TroisJoueurs();
        }
    }
}
