using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportal : MonoBehaviour
{
    public GameObject Teleport;
    public GameObject Player;
    //public GameObject TeleportTo;
    private SceneChange sceneChange;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            Debug.Log("This is a check.");
        }
    }
}
