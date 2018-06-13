using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour {

    public string cameraVertical;
    private float h;
    void Update()
    {
        h = Input.GetAxis(cameraVertical) * Time.deltaTime * 150.0f;
        transform.Rotate(-h, 0, 0);
    }
}
