using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerTutorial : MonoBehaviour {

    public float Stamina = 1;
    public Image StaminaBar;
    public bool IsRecharging;
    public float Invert = 1;
    public GameObject Sword;
    public bool touched = false;
    public bool isAlive = true;
    public string
        moveHorizontal, moveVertical, cameraHorizontal, jumpAround, triggerRun;
    bool Jump = false;
    public void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity * GetComponent<Rigidbody>().mass * 10);
    }
    public void Gravity()
    {
        Physics.gravity = new Vector3(0, -3F, 0);
    }
    void WhereToGo()
    {
        transform.position = new Vector3(0, 5, 0);
    }
    void Start()
    {
        Gravity();
    }
    void Update()
    {
        if (CodeTuto.Singleton.Step9 == true && Input.GetButtonDown("Jump_P1"))
        {
            SceneManager.LoadScene("Menu");
        }
        if(CodeTuto.Singleton.Step8 == true && Input.GetButtonDown("ToThrow_P1") && CodeTuto.Singleton.Step9 == false)
        {
            CodeTuto.Singleton.Step9 = true;
            CodeTuto.Singleton.Step8T.SetActive(false);
            CodeTuto.Singleton.Step9T.SetActive(true);
            CodeTuto.Singleton.ContinuePls.SetActive(true);
        }
        StaminaBar.fillAmount = Stamina;
        if (isAlive == true)
        {
            var x = Input.GetAxis(moveHorizontal) * Time.deltaTime * 8f;
            var z = Input.GetAxis(moveVertical) * Time.deltaTime * 8f;
            var g = Input.GetAxis(cameraHorizontal) * Time.deltaTime * 150.0f;
            if (CodeTuto.Singleton.Step2 == true)
            {
                transform.Translate(0, 0, z * Invert);
                transform.Translate(-x * Invert, 0, 0);
                if (x != 0 && CodeTuto.Singleton.Step3 == false || z != 0 && CodeTuto.Singleton.Step3 == false)
                {
                    CodeTuto.Singleton.Step3 = true;
                    CodeTuto.Singleton.Step2T.SetActive(false);
                    CodeTuto.Singleton.Step3T.SetActive(true);
                }
            }
            if (CodeTuto.Singleton.Step3 == true)
            {
                transform.Rotate(0, -g, 0);
                if (g != 0 && CodeTuto.Singleton.Step4 == false)
                {
                    CodeTuto.Singleton.Step4 = true;
                    CodeTuto.Singleton.Step3T.SetActive(false);
                    CodeTuto.Singleton.Step4T.SetActive(true);
                }
            }
            if (CodeTuto.Singleton.Step4 == true && Input.GetButtonDown(jumpAround) && Jump == false)
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * 10f;
                Jump = true;
                if (CodeTuto.Singleton.Step5 == false)
                {
                    CodeTuto.Singleton.Step5 = true;
                    CodeTuto.Singleton.Step4T.SetActive(false);
                    CodeTuto.Singleton.Step5T.SetActive(true);
                }
            }
            if (CodeTuto.Singleton.Step5 == true)
            {
                if (!IsRecharging && Input.GetAxis(triggerRun) < 0)
                {
                    Stamina = 0;
                    IsRecharging = true;
                    GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                    StartCoroutine(StaminaWaiting());
                    if (CodeTuto.Singleton.Step6 == false)
                    {
                        CodeTuto.Singleton.Step6 = true;
                        CodeTuto.Singleton.Step5T.SetActive(false);
                        CodeTuto.Singleton.Step6T.SetActive(true);
                    }
                }
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Jump = false;
        }
        if (col.gameObject.tag == "Ceiling")
        {
            AboveWater();
        }
        if (col.gameObject.name == "sword kinda" && touched == false && col.gameObject.tag != gameObject.tag || col.gameObject.tag == "Water")
        {
            transform.position = new Vector3(0, 5, 0);
            if (col.gameObject.tag == "Water")
            {
                Sword.SetActive(false);
            }
            WhereToGo();

        }
    }
    void AboveWater()
    {
        WhereToGo();
    }
    IEnumerator StaminaWaiting()
    {
        yield return new WaitForSeconds(3);
        Stamina = 1;
        IsRecharging = false;
    }
}
