using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhoWon : MonoBehaviour {
    public int WinnerNumber;
    public static WhoWon Singleton;
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
    }
    
}
