using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject,5);
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.back * speed*Time.deltaTime;
    }


   

    /* private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag.Equals("Player"))
         {
             // SwipeMovement player=collision.gameObject.GetComponent<SwipeMovement>();

             SceneManager.LoadScene("SampleScene");
         }
     } */

}
