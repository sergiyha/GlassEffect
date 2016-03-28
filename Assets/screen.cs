using UnityEngine;
using System.Collections;


public class screen : MonoBehaviour

{

    public Renderer renderer;
    Texture2D screenCap;
    Texture2D border;
    bool shot = false;
    private glassController glassController;

    // Use this for initialization
    void Start()
    {
        GameObject glassControllerObject = GameObject.FindWithTag("MainCamera");
        glassController = glassControllerObject.GetComponent<glassController>();

        screenCap = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24,false); // 1
    }

    void OnPostRender()
    {
        renderer.material.mainTexture = screenCap;
      screenCap.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
      screenCap.Apply();
        
    }

   
}
