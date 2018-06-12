using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiHowMany : MonoBehaviour {

    public static MultiHowMany Singleton;
    public int PlayerNumber = 4;
    public int MapCategory = 1;
    private void Awake()
    {
        if(Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void DeuxJoueurs()
    {
        PlayerNumber = 2;
    }

    public void TroisJoueurs()
    {
        PlayerNumber = 3;
    }

    public void QuatreJoueurs()
    {
        PlayerNumber = 4;
    }

    public void WhatMap()
    {
        MapCategory = 1;
    }

    public void ThisMap()
    {
        MapCategory = 2;
    }

}
