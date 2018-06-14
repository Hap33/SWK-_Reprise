using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovingTuto : MonoBehaviour {

    public string cameraVertical;
    private float h;
    void Update()
    {
        if (CodeTuto.Singleton.Step3 == true)
        {
            h = Input.GetAxis(cameraVertical) * Time.deltaTime * 150.0f;
            transform.Rotate(-h, 0, 0);
            if (h != 0 && CodeTuto.Singleton.Step4 == false)
            {
                CodeTuto.Singleton.Step4 = true;
                CodeTuto.Singleton.Step3T.SetActive(false);
                CodeTuto.Singleton.Step4T.SetActive(true);
            }
        }
    }
}
