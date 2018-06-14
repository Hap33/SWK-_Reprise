using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMe : MonoBehaviour {
    public GameObject WhoToLook;
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(WhoToLook.transform);
	}
}
