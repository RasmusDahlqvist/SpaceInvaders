using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    private Transform bullet;
    public float speed;
    public float height;
    public int bigHealth = 3;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        bullet.position += Vector3.up * 16 * Time.deltaTime;

        if (bullet.position.y >= height)
            Destroy(gameObject);
    }

    //tormays viholliseen 
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            //Debug.Log(PlayerScore.score);
            PlayerScore.score += 10;
        }

       else if (other.tag == "EnemyBigPinkki")
        {
            // Destroy(other.gameObject);
            Destroy(gameObject);
            //Debug.Log(PlayerScore.score);
            PlayerScore.score += 10;
            BigEnemyHealth.Pinkkihealth--;
            

            if (BigEnemyHealth.Pinkkihealth <= 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("EnemyBigPinkki"));
                

            }



        }

        

      else  if (other.tag == "EnemyBigSininen")
            {
                // Destroy(other.gameObject);
                Destroy(gameObject);
                //Debug.Log(PlayerScore.score);
                PlayerScore.score += 10;
                BigEnemyHealth.Sininenhealth--;
                


            if (BigEnemyHealth.Sininenhealth <= 0)
            {
                Destroy(other.gameObject);
                
            }



        }

          







          else  if (other.tag == "EnemyBigKeltainen")
            {
                // Destroy(other.gameObject);
                Destroy(gameObject);
                //Debug.Log(PlayerScore.score);
                PlayerScore.score += 10;
                BigEnemyHealth.Keltainenhealth--;
                


            if (BigEnemyHealth.Keltainenhealth <= 0)
            {
                Destroy(other.gameObject);
                Debug.Log("keltainenkuoli");
            }




        }






        else if (other.tag == "Base")
            {

                Destroy(gameObject);
            }

        }
    }

