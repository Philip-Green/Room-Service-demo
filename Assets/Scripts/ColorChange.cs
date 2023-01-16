using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.IO;


public class ColorChange : MonoBehaviour
{
   
    public Color[] colors;
    public int colorIndex;
  
    // Start is called before the first frame update
    void Start()
    {
       


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




