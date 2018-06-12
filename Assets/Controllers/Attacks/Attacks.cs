using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour {
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;
    public GameObject Spawner5;
    public GameObject Spawner6;
    public GameObject Spawner7;
    public Vector3 FinalSpawner;
    public int SpawnerChoice;
    public AudioClip gotAKnight;
    public AudioSource fromThere;
    public GameObject Object;
    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }
    public WakeUp epee;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("epee") && epee.IsActive == false)
        {
            fromThere.PlayOneShot(gotAKnight);
            SpawnerChoice = Random.Range(1, 8);
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
                default:
                    FinalSpawner = new Vector3(250, 250, 250);
                    break;
            }
            other.transform.position = FinalSpawner;
            Instantiate(Object, gameObject.transform.position, gameObject.transform.rotation);
            epee.Activate();
        }
    }
}
