using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomTrigger : MonoBehaviour
{
    public int roomNumber;
    public Transform spawnPoint;
    public float monsterSpawnChance;
    private float mChance;
    public float keySpawnChance;
    private float kChance;
    // public Transform keyspawn;
    public Manager man;
    private Collider col;
  
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();// gets a component if none exists. 
        
    }

    // Update is called once per frame
    void Update()
    {
        mChance = 1 - (monsterSpawnChance / 100);
        kChance = 1 - (keySpawnChance / 100);
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("Player has entered Room " + roomNumber); //Just a check. 
            if (Random.value > mChance) //This determines a monster spawn. 
            {
                man.SpawnEnemyAtLocation(spawnPoint);
                man.OnEncounter();
                

            }
            else
            {
                //Debug.Log("phew...");
                if(other.tag== "Player")
                {
                    if (Random.value > kChance)
                    {
                        man.KeySpawnOnLocation(spawnPoint);
                    }
                    
                }


            }
            col.enabled = false;// Disables the collider. 

        }
    }
    
   
}
