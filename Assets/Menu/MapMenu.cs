using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMenu : MonoBehaviour {
    private static MapMenu instance = null;
    public static MapMenu Instance;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        transform.Rotate(0, 0.5f, 0);
        if(SceneManager.GetActiveScene().buildIndex > 10 || SceneManager.GetActiveScene().buildIndex == 9)
        {
            Debug.Log("Message");
            Destroy(this.gameObject);
        }
    }

}
