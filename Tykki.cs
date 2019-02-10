using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tykki : MonoBehaviour {


    public GameObject shot;  //voidaan sijoittaa bullet scripti
    public Transform shotSpawn; //raahataan unityssa player gameobjecti tähä joten bulletit tulee samasta kohtaa kuin pelaaja 
    public float fireRate;
    //public float myTime;

    private float nextFire;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // myTime = myTime + Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // parametrit: mistä kopio, uuden objektin sijainti 
        }

    }
}

