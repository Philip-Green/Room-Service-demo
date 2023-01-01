using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class encounterTracker : MonoBehaviour
{   //This script is suppose to keep track of # of times player encounters a monster
    //Have the array hold the amount of times the player can encounter a monster before game over, and as each
    //Time the player encounters a monster, the total amount subtracts by one.
    // Start is called before the first frame update
    public int keepTrack = 0;
    public int maxEncounters = 5;
    //DoorScript doorScript 
    //script reference might be needed in order for this script to properly keep count of monster encounters
    
    int[] monsterArray = new int[5];// holds the amount of times the player can encounter a monster before game over. 

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (keepTrack == maxEncounters)
        {
            SceneManager.LoadScene(2); //keepTrack equals zero, then load the game over scene.

        }
        //Monster();
    }

    public void OnEncounter()
    {
        keepTrack++;
    }


    void Monster()
    {
        for (int i = keepTrack; i <= monsterArray.Length; i--)
        {
            Debug.Log("You've encountered a monster");
            //have the UI ex-out one of the numbers from the encounter bar.  
            if (keepTrack == 0) 
            {
                SceneManager.LoadScene(2); //keepTrack equals zero, then load the game over scene.
            }
            
            



        }
    }
}
