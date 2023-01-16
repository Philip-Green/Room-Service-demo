using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Teleportal : MonoBehaviour
{
    public GameObject Teleport;
    public GameObject Player;
    //public GameObject TeleportTo;
    private SceneChange sceneChange;
    // Start is called before the first frame update


    void Start()
    {
        sceneChange = GameObject.Find("SceneChange").GetComponent<SceneChange>();
        //TeleportTo= GameObject.Find("Teleportal2").GetComponent<GameObject>();



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("This is a check.");
            sceneChange.LoadSceneWithIntegerID(4);
            //TeleportTo.SetActive(true);

        }
    }
}
