using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);

    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);

    }
}
