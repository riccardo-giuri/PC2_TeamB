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
        SceneManager.LoadScene("Prototype13_02");
    }

    public void PlayScene2()
    {
        SceneManager.LoadScene("Persia Scene");
    }

    public void PlayScene3()
    {
        SceneManager.LoadScene("PrototypeLockdown");
    }

    public void PlayScene4()
    {
        SceneManager.LoadScene("PrototypeThomas");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
