using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShower : MonoBehaviour {

    public Text TheWinnerIs;

    private void Update()
    {
        switch (WhoWon.Singleton.WinnerNumber)
        {
            case 1:
                TheWinnerIs.text = "Excalibur (J1) a gagné";
                break;
            case 2:
                TheWinnerIs.text = "Clarente (J2) a gagné";
                break;
            case 3:
                TheWinnerIs.text = "Jovial (J3) a gagné";
                break;
            case 4:
                TheWinnerIs.text = "Durendal (J4) a gagné";
                break;
            default:
                TheWinnerIs.text = "Hmmm, Il y a eu une erreur";
                break;
        }
    }
}
