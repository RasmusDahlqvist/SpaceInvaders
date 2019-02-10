using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Transform player;
    public float speed;
    public float startEdge,width;



    /*
    public GameObject shot;  //voidaan sijoittaa bullet scripti
    public Transform shotSpawn; //raahataan unityssa player gameobjecti tähä joten bulletit tulee samasta kohtaa kuin pelaaja 
    public float fireRate;
    //public float myTime;

    private float nextFire;
    */

	// Use this for initialization
	void Start () {
        player = GetComponent<Transform>(); //hankitaan pääsy transformiin
	}

    // Update is called once per frame
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Store the current vertical input in the float moveVertical.

        if (player.position.x < startEdge && moveHorizontal < 0)
            moveHorizontal = 0;
        else if (player.position.x > width & moveHorizontal > 0)
            moveHorizontal = 0;

        player.position += Vector3.right * moveHorizontal * speed * Time.deltaTime;


    }


    /*
    void Update() { 

       // myTime = myTime + Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // parametrit: mistä kopio, uuden objektin sijainti 
        }

    }
    */
}
