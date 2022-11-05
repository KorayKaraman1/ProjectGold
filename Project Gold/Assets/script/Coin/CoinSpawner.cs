using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public SwipeMovement PlayerScript;
    public GameObject coins;

    public float height;
    public float time;
    void Start()
    {
        StartCoroutine(spawnObject2(time));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator spawnObject2(float time)
    {
        while (!PlayerScript.isDead)
        {
            Instantiate(coins, new Vector3(Random.Range(-height, height), 2, 80), Quaternion.identity);
            
            yield return new WaitForSeconds(time);
        }

    }
}
