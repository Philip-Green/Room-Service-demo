using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    private SceneChange sceneChange;
    // Start is called before the first frame update
    void Start()
    {
        sceneChange = GameObject.Find("SceneChange").GetComponent<SceneChange>();
  
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("Hit");
            //SceneManager.LoadScene(3);
            sceneChange.LoadSceneWithIntegerID(3);

        }
    }




}
