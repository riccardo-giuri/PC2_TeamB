using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuPanel;
    public bool IsStopped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsStopped == false)
            {
                Time.timeScale = 0;
                PauseMenuPanel.SetActive(true);
                IsStopped = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                PauseMenuPanel.SetActive(false);
                IsStopped = false;
                StartCoroutine(Locking());
            }
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseMenuPanel.SetActive(false);
        IsStopped = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    IEnumerator Locking()
    {
        yield return new WaitForSeconds(0.4f);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
