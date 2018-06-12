using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("PlayerNumber");
    }
    public void GetOut()
    {
        SceneManager.LoadScene("Menu");
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    public void Scene2p()
    {
        SceneManager.LoadScene("ReadyUp_2p");
    }
    public void Scene3P()
    {
        SceneManager.LoadScene("ReadyUp_3p");
    }
    public void Scene4P()
    {
        SceneManager.LoadScene("ReadyUp_4p");
    }
    public void SceneCredits()
    {
        SceneManager.LoadScene("GlobalScore");
    }
    public void Creditz()
    {
        SceneManager.LoadScene("Histoire");
    }
    public void Map(int PlayerWeWant)
    {
        SceneManager.LoadScene("MapSelect");
        MultiHowMany.Singleton.PlayerNumber = PlayerWeWant;
    }
    public void LoadMap( int Map)
    {
        MultiHowMany.Singleton.MapCategory = Map;
        if (MultiHowMany.Singleton.PlayerNumber == 2)
        {
            SceneManager.LoadScene("ReadyUp_2p");
        }
        if (MultiHowMany.Singleton.PlayerNumber == 3)
        {
            SceneManager.LoadScene("ReadyUp_3p");
        }
        if (MultiHowMany.Singleton.PlayerNumber == 4)
        {
            SceneManager.LoadScene("ReadyUp_4p");
        }
    }
}
