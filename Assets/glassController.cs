using UnityEngine;
using System.Collections;

public class glassController : MonoBehaviour
{
    public Texture2D glassCap;

    void Start()
    {
        glassCap = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24,false);
    }
    void OnPostRender() {
        glassCap.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        glassCap.Apply();
    } 
  
}
