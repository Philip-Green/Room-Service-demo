using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDetection : MonoBehaviour
{
    public float detectionRadius;
    public float detectonAngle;
    // Start is called before the first frame update
    //  This script is designed to have enemies detect, and chase the player when found. 
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        lookforPlayer();
    }
    
    private void lookforPlayer()
    {
        //GameObject.FindG("Player");
        

    }

}
