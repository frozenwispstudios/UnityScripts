using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Camera
public class ScreenshotHandler : MonoBehaviour
{
    private Camera mainCamera;
    private bool takeScreenShotNextFrame;

    // Start is called before the first frame update
    void Awake()
    {
        mainCamera = gameObject.GetComponent<Camera>();
    }

    //This function runs like a update even
    private void OnPostRender()
    {
        if (takeScreenShotNextFrame)
        {
            takeScreenShotNextFrame = false;
            
            //Create 2D texture to store the image on
            RenderTexture renderTexture = mainCamera.targetTexture;
            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            renderResult.ReadPixels(rect, 0, 0);
            byte[] byteArray = renderResult.EncodeToPNG();

            //image save location
            System.IO.File.WriteAllBytes(System.Environment.SpecialFolder.MyComputer + "TESTSAVE.png", byteArray);

            //Debug.LogWarning(System.Environment.SpecialFolder.MyComputer + " TESTSAVE.png");

            //reset variables and texture to be reused
            RenderTexture.ReleaseTemporary(renderTexture);
            mainCamera.targetTexture = null;
        }
    }

    //call this funtion from a button to take screenshots
    public void TakeScreenShot(int width, int height)
    {
        mainCamera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeScreenShotNextFrame = true;
    }


    //Press space to take a screen shot from the main camera
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            TakeScreenShot(Screen.width, Screen.height);//get the current screen width and height for the shot
        }
    }
}
