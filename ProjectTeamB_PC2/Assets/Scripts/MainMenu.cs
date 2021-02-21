using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string scene1;
    public string scene2;
    public string scene3;
    public string scene4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayScene1()
    {
        SceneManager.LoadScene(scene1);
    }

    public void PlayScene2()
    {
        SceneManager.LoadScene(scene2);
    }

    public void PlayScene3()
    {
        SceneManager.LoadScene(scene3);
    }

    public void PlayScene4()
    {
        SceneManager.LoadScene(scene4);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
