using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameManager : MonoBehaviour
{
    private SceneChange sceneChange;
    // Start is called before the first frame update
    void Start()
    {
        sceneChange = GameObject.Find("SceneChange").GetComponent<SceneChange>();


    }

    public void Reload()
    {
        sceneChange.LoadSceneWithIntegerID(0);
    }

}
