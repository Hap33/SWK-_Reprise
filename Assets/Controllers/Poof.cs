using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Poof : MonoBehaviour
{
    public float RangeX1;
    public float RangeX2;
    public float RangeY1;
    public float RangeY2;
    public float[] TpLocation = new float[2];
    public float Height;
    // Use this for initialization
    void Awake()
    {
        WhereToGo();
    }
    void WhereToGo()
    {
        TpLocation[0] = Random.Range(RangeX1, RangeX2);
        TpLocation[1] = Random.Range(RangeY1, RangeY2);
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
