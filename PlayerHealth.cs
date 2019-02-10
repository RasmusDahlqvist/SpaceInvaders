using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public static  int health = 3;
    

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (health == 0) {
            FindObjectOfType<GameManager>().EndGame();
            //Debug.Log("HEaltthi: " + health);
        }
	}
}
