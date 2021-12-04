using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetDestroy : MonoBehaviour
{
     
    private void OnMouseDown()
    {
       
        Destroy(this.gameObject);
        
        Score.scoreValue +=1;

    }

    
}
