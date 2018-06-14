using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeTuto : MonoBehaviour {

    public GameObject Step1T;
    public GameObject Step2T;
    public GameObject Step3T;
    public GameObject Step4T;
    public GameObject Step5T;
    public GameObject Step6T;
    public GameObject Step7T;
    public GameObject Step8T;
    public GameObject Step9T;
    public GameObject ContinuePls;
    public bool Step1 = true;
    public bool Step2 = false;
    public bool Step3 = false;
    public bool Step4 = false;
    public bool Step5 = false;
    public bool Step6 = false;
    public bool Step7 = false;
    public bool Step8 = false;
    public bool Step9 = false;
    public static CodeTuto Singleton;

    void Awake()
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

    private void Update()
    {
        if (Step1 == true && Input.GetButtonDown("Jump_P1") && Step2 == false)
        {
            ContinuePls.SetActive(false);
            Step1T.SetActive(false);
            Step2T.SetActive(true);
            Step2 = true;
        }
        if (Step6 == true && Input.GetButtonDown("Jump_P1") && Step7 == false)
        {
            ContinuePls.SetActive(false);
            Step6T.SetActive(false);
            Step7T.SetActive(true);
            Step7 = true;
        }
        if (Step1 == true && Step2 == false)
        {
            ContinuePls.SetActive(true);
        }
        if (Step6 == true && Step7 == false)
        {
            ContinuePls.SetActive(true);
        }
    }
}
