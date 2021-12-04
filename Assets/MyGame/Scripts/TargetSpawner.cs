using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

 
    public GameObject[] target;

    
    public void Start()
    {
        SpawnTarget();
    }

    
    public void SpawnTarget()
    {

        GameObject targetPosition = Instantiate(target[Random.Range(0, target.Length)]);
        targetPosition.transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);


        
        /*if (score.gameScore < 9)
        {
            StartCoroutine(SpawnAfterTime());
        }
        else
        {
            StopCoroutine(SpawnAfterTime());


          Instantiate(target, targetPosition, Quaternion.identity);
        }*/
    }
}
