using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetDestroy : MonoBehaviour
{
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<AudioSource>().Play(0);
        }

    }

    public void OnMouseDown()
    {
       
        Destroy(this.gameObject);
        
        ScoreManager.scoreValue +=1;

       

     
    }

  

}
