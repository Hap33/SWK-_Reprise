using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhosReady : MonoBehaviour {
    public static int NumberOfReady = 0;

    private void Awake()
    {
        NumberOfReady = 0;
    }
    void Update () {
		if (NumberOfReady == 4)
        {
            if (MultiHowMany.Singleton.MapCategory == 1)
            {
                SceneManager.LoadScene("Map1Play");
            }
            if (MultiHowMany.Singleton.MapCategory == 2)
            {
                SceneManager.LoadScene("map_2");
            }
            if (MultiHowMany.Singleton.MapCategory == 3)
            {
                SceneManager.LoadScene("Map_3");
            }
            MultiHowMany.Singleton.QuatreJoueurs();
        }
	}
}
