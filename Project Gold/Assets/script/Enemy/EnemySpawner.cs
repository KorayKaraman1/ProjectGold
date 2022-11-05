using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public SwipeMovement PlayerScript;
    public GameObject enemys;
    
        
    public float height;
    public float time;
    void Start()
    {
       StartCoroutine(spawnObject(time));

    }

    
    void Update()
    {
       
    }
    public IEnumerator spawnObject(float time)
    {
        
        
            while (!PlayerScript.isDead)
            {
                Instantiate(enemys, new Vector3(Random.Range(-height, height), 2, 80), Quaternion.identity);
                // Instantiate(enemys, new Vector3(Random.Range(-height, height), 2, 80), Quaternion.identity);
                yield return new WaitForSeconds(time);
            }
        
    }


}
