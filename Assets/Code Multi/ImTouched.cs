using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImTouched : MonoBehaviour {
    public GameObject Knight;
    private void Update()
    {
        if (CodeTuto.Singleton.Step7 == true)
        {
            Knight.SetActive(true);
            GetComponent<Rigidbody>().useGravity = true;
            /*CodeTuto.Singleton.Step8 = true;
            CodeTuto.Singleton.Step7T.SetActive(false);
            CodeTuto.Singleton.Step8T.SetActive(true);*/
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "P1" && CodeTuto.Singleton.Step7 == true)
        {
            CodeTuto.Singleton.Step8 = true;
            CodeTuto.Singleton.Step7T.SetActive(false);
            CodeTuto.Singleton.Step8T.SetActive(true);
            Destroy(gameObject);
        }
    }
}
