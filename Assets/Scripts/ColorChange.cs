using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.IO;


public class ColorChange : MonoBehaviour
{
    //Manager man;
    //public GameObject enemyPrefab;
    //RoomTrigger trigger;
    //List<Color> colors1= new List<Color>();
    //List<Color> colors2 = new List<Color>();

    public Color[] colors;
    public int colorIndex;
  
    // Start is called before the first frame update
    void Start()
    {
        //colors1.Add(new Color(0, 0, 1)); // adding elements using add() method
        //colors1.Add(new Color(1, 0, 0));
        //colors1.Add(new Color(1, 1, 0));
        //colors1.Add(new Color(1, 1, 1));
        //colors1.Add(new Color(.5f,0,.5f));
        //colors1.Add(new Color(0, 1, 0));
        //colors1.Add(new Color(0, 0, 0));
        //enemyPrefab = gameObject;


    }


    public Color GetNextColor()
    {
        if(colorIndex + 1 >= colors.Length)
        {
            colorIndex = 0;
        }
        colorIndex++;
        return colors[colorIndex];
    }

            

}




