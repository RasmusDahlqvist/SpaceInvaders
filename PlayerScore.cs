using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour {

    public static int  score = 0;
    private Text scoreText; 

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "S C O R E : " + score;
	}
}
