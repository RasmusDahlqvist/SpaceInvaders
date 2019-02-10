using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour {

    public Transform playerBase;
    public float health; 


	// Use this for initialization
	void Start () {
        playerBase = GetComponent<Transform>();
      
	}
	
	// Update is called once per frame
	void Update () {

        if (health <= 0)
        {
            Destroy(gameObject);
        }
       
	}
}
