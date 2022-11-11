using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Scenechange(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void quit()
    {
        Application.Quit();
    }
   


}
