using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSceneWithIntegerID(int whichScene)
    {
        Debug.Log("Reload clicked");
        SceneManager.LoadScene(whichScene);
    }
    public void Exit()
    {
        Application.Quit();
    }

    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
