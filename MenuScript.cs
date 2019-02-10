using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {


   // public Button PlayButton;

    




     public void ChangeScene(string sceneName) {

        SceneManager.LoadScene(sceneName);
    }

    
   
    
    // Use this for initialization
    void Start()
    {
    }
	// Update is called once per frame
	void Update () {
		
	}
}
