using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Poof : MonoBehaviour
{
    public float[] TpLocation = new float[2];
    public float Height;
    // Use this for initialization
    void Awake()
    {
        WhereToGo();
    }
    void WhereToGo()
    {
        TpLocation[0] = Random.Range(0, 500);
        TpLocation[1] = Random.Range(0, 500);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ceiling"||col.gameObject.tag == "Water")
        {
            WhereToGo();
            transform.position = new Vector3(TpLocation[0], Height, TpLocation[1]);
        }
    }
}
