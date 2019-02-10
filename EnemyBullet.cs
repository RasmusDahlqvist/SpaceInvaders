using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    private Transform bullet;
    public float speed;

    
    

	// Use this for initialization
	void Start () {
        bullet = GetComponent<Transform>();
	}

    void FixedUpdate() {
        bullet.position += Vector3.up * -15 * Time.deltaTime;

        if (bullet.position.y < -10) {
            Destroy(bullet.gameObject);
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            PlayerHealth.health--;
            Debug.Log("HEaltthi: " + PlayerHealth.health);
            // Destroy(other.gameObject);
            Destroy(gameObject);
            //toimmii jes!!
            PlayerLives.lives--;
        }

        if (PlayerHealth.health <= 0) {
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }


        else if (other.tag == "Base") {

            GameObject playerBase = other.gameObject;
            BaseScript baseHealth = playerBase.GetComponent<BaseScript>();
            baseHealth.health -= 1;
            Destroy(gameObject);
        }
    }


	// Update is called once per frame

}
