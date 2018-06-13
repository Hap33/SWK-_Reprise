using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float Invert = 1;
    public GameObject Sword;
    public float Vitesse;
    public float JumpHeight;
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;
    public GameObject Spawner5;
    public GameObject Spawner6;
    public GameObject Spawner7;
    public GameObject Spawner8;
    public Vector3 FinalSpawner;
    public int SpawnerChoice;
    public float[] TpLocation= new float[2];
    //private float RandomSound;
    public bool touched = false;
    /*public AudioClip dieLikeAGoat;
    public AudioClip boing1;
    public AudioClip boing2;
    public AudioClip boing3;
    public AudioClip boing4;
    public AudioClip boing5;
    public AudioClip boing6;*/
    public AudioClip splash;
    public AudioSource deathSound;
    public string
        moveHorizontal, moveVertical, cameraHorizontal, jumpAround;
    public bool isAlive = true;
    bool Jump = false;
    public void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity * GetComponent<Rigidbody>().mass * 10);
    }
    public void Gravity()
    {
        Physics.gravity = new Vector3(0, -3F, 0);
    }
    private void Awake()
    {
        deathSound = GetComponent<AudioSource>();
        WhereToGo();
    }
    void WhereToGo()
    {
        SpawnerChoice = Random.Range(1, 9);
        switch (SpawnerChoice)
        {
            case 1:
                FinalSpawner = new Vector3(Spawner1.transform.position.x, Spawner1.transform.position.y, Spawner1.transform.position.z);
                break;
            case 2:
                FinalSpawner = new Vector3(Spawner2.transform.position.x, Spawner2.transform.position.y, Spawner2.transform.position.z);
                break;
            case 3:
                FinalSpawner = new Vector3(Spawner3.transform.position.x, Spawner3.transform.position.y, Spawner3.transform.position.z);
                break;
            case 4:
                FinalSpawner = new Vector3(Spawner4.transform.position.x, Spawner4.transform.position.y, Spawner4.transform.position.z);
                break;
            case 5:
                FinalSpawner = new Vector3(Spawner5.transform.position.x, Spawner5.transform.position.y, Spawner5.transform.position.z);
                break;
            case 6:
                FinalSpawner = new Vector3(Spawner6.transform.position.x, Spawner6.transform.position.y, Spawner6.transform.position.z);
                break;
            case 7:
                FinalSpawner = new Vector3(Spawner7.transform.position.x, Spawner7.transform.position.y, Spawner7.transform.position.z);
                break;
            case 8:
                FinalSpawner = new Vector3(Spawner8.transform.position.x, Spawner8.transform.position.y, Spawner8.transform.position.z);
                break;
            default:
                FinalSpawner = new Vector3(250, 250, 250);
                break;
        }
        transform.position = FinalSpawner;
        /*TpLocation[0] = Random.Range(RangeX1, RangeX2);
        TpLocation[1] = Random.Range(RangeY1, RangeY2);*/
    }
    void Start()
    {
        Gravity();
    }
    void Update()
    {
        if (isAlive == true)
        {
            var x = Input.GetAxis(moveHorizontal) * Time.deltaTime * Vitesse;
            var z = Input.GetAxis(moveVertical) * Time.deltaTime * Vitesse;
            var g = Input.GetAxis(cameraHorizontal) * Time.deltaTime * 150.0f;
            transform.Translate(0, 0, z * Invert);
            transform.Translate(-x * Invert, 0, 0);
            transform.Rotate(0, -g, 0);
            if (Input.GetButtonDown(jumpAround) && Jump == false)
            {
                GetComponent<Rigidbody>().velocity = Vector3.up * JumpHeight;
                Jump = true;
                //WhatToSay();
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
        if (col.gameObject.name == "sword kinda"&& touched == false && col.gameObject.tag != gameObject.tag|| col.gameObject.tag == "Water")
        {
            transform.position = FinalSpawner;
            if (col.gameObject.tag == "Water")
            {
                Sword.SetActive(false);
                deathSound.PlayOneShot(splash);
            }
            /*if (col.gameObject.name == "sword kinda")
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }*/
            //deathSound.PlayOneShot(dieLikeAGoat);
            WhereToGo();

            /*isAlive = false;
            WhoAmI();
            if (col.gameObject.tag == "Water")
            {
                deathSound.PlayOneShot(splash);
            }
            transform.GetChild(0).gameObject.SetActive(false);
            if (col.gameObject.name == "sword kinda")
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
            transform.DetachChildren();
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            deathSound.PlayOneShot(dieLikeAGoat);
            touched = true;
            GetComponent<Collider>().isTrigger = true;*/

        }
    }
    void AboveWater() {
        WhereToGo();
    }
    
    /*void WhatToSay()
    {
        RandomSound = Random.Range(0, 60);
        if (RandomSound <= 10)
        {
            deathSound.PlayOneShot(boing1);
        }
        if (RandomSound > 10 && RandomSound <= 20)
        {
            deathSound.PlayOneShot(boing2);
        }
        if (RandomSound > 20 && RandomSound <= 30)
        {
            deathSound.PlayOneShot(boing3);
        }
        if (RandomSound > 30 && RandomSound <= 40)
        {
            deathSound.PlayOneShot(boing4);
        }
        if (RandomSound > 40 && RandomSound <= 50)
        {
            deathSound.PlayOneShot(boing5);
        }
        if (RandomSound > 50)
        {
            deathSound.PlayOneShot(boing6);
        }
    }*/
}
