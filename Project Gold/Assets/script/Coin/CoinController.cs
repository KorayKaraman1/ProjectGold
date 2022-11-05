using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 5);
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
   
}
