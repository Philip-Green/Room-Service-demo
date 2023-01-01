using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    //This script is to trigger an event once the player opens a door with a monster in it. 
    // Start is called before the first frame update
    bool hasMonster;
    public Transform spawnPoint;
    public GameObject enemyPrefab;
    public DoorScript[] allDoors;
    public List<DoorScript> doorsThatTriggerMonsters = new List<DoorScript>();
    int amountOfMonstersToSpawn;
    void Start()
    {
        hasMonster = false;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i < amountOfMonstersToSpawn; i++) // for loop for the amount of monsters spawned. 
        {
            Debug.Log("Monster triggered");
            int x = Random.Range(0, allDoors.Length);// x is holding a random number range from 0 to the total amount of doors.
            while (doorsThatTriggerMonsters.Contains(allDoors[x]))// a while loop detailing...
            {
                x = Random.Range(0, doorsThatTriggerMonsters.Count);
                Debug.Log("Monster triggered");
            }

            doorsThatTriggerMonsters.Add(allDoors[x]);

        }
        
        foreach(DoorScript door in doorsThatTriggerMonsters) // I believe this script thinks all the doors trigger monsters. 
        {
            door.hasMonster = true;
            //Debug.Log("Door script works"); 
        }
    }


    void spawnMonster()
    {

    }

}
