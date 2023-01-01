using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public SceneChange sceneChange;
    public ColorChange cc;
    
    private int keepTrack = 0;
    private int maxEncounters = 5;
    

    public GameObject enemyPrefab;
    public GameObject keyPrefab;
    public Image[] images;
    // Start is called before the first frame update
    public void DecrementUI()
    {
        images[keepTrack].enabled = false;
    }
    private void Awake()
    {
        keepTrack = maxEncounters;
        
        
    }

    public enum Statetype
    {
        DEFAULT,
        GAMEOVER,
        GAMESTART,


    }

    public void OnEncounter()
    {
        keepTrack--;
        if (keepTrack > 0)
        {
            DecrementUI();
        }
       
    }
    public void Play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //sceneChange.LoadSceneWithIntegerID(2);
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (keepTrack == -1)
        {
            sceneChange.LoadSceneWithIntegerID(2);
            //SceneManager.LoadScene(2); //keepTrack equals zero, then load the game over scene.

        }


        /*if (key == false) //the idea here is to have the scene change occur when the key is found. 
        {
            Debug.Log("This part works");
        }
        else
        {
            
        }*/

            

    }

    public void SpawnEnemyAtLocation(Transform spawnPoint)
    {
        GameObject enemy= Instantiate(enemyPrefab, spawnPoint.position, enemyPrefab.transform.localRotation);
        var rend = enemy.GetComponentInChildren<Renderer>();
        var mat = rend.materials[4];

        mat.SetColor("_Color", cc.GetNextColor());

        //enemy.GetComponent<ColorChange>().colorpicked();
    }

    public void KeySpawnOnLocation(Transform keyspawn)
    {
        Instantiate(keyPrefab, keyspawn.position, Quaternion.identity);
    }
}
