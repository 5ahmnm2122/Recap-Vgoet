using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

 
    public GameObject[] target;
 

    public void Start()
    {
       StartCoroutine(SpawnTarget());
    }

    
    public IEnumerator SpawnTarget()
    {
   

        GameObject targetPosition = Instantiate(target[Random.Range(0, target.Length)]);
        targetPosition.transform.position = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);

        yield return new WaitForSeconds(2);

    

        if (ScoreManager.scoreValue < 10)
        {
            StartCoroutine(SpawnTarget());
           
        }
        else
        {
            StopCoroutine(SpawnTarget());
        }

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<AudioSource>().Play(0);
        }

    }

}
