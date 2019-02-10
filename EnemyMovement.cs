using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour {

    private Transform viholliset;
    public float speed;
    public EnemyBullet eb; 
    public GameObject Shot;

  
   
    public float fireRate = 0.9f; 
	// Use this for initialization
	void Start () {
      
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f); //Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds.
        viholliset = GetComponent<Transform>();

    }


    void MoveEnemy() {

        
        
            viholliset.position += Vector3.right * speed;

            foreach (Transform enemy in viholliset)
            {
                if (enemy.position.x < -13 || enemy.position.x > 13)
                {
                    speed *= -1;
                    viholliset.position += Vector3.down * 0.5f;
                    return;

                }
         //   Debug.Log(enemy.position.y);
           
                //vihollinen ampuu random ajan välein
                if (Random.value > fireRate)
                {
                    Instantiate(Shot, enemy.position, enemy.rotation);
                }

                if (enemy.position.y < -4)
                {
                FindObjectOfType<GameManager>().EndGame();

                }
            }

            if (viholliset.childCount == 1)
            {
                CancelInvoke();
                InvokeRepeating("MoveEnemy", 0.1f, 0.8f);
            }


            if (viholliset.childCount == 0 )
            {
           
            
               FindObjectOfType<GameManager>().GameWon();
                //Time.timeScale = 0;
            }
            
           
            









        }
        
    
	
	// Update is called once per frame
	void Update () {

    }
}
