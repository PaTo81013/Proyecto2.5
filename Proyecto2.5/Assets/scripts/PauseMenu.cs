using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseBotton;
    [SerializeField] private GameObject Pausemenu;

   public void Pause()
    {
        Time.timeScale = 0f;
        PauseBotton.SetActive(false);
        Pausemenu.SetActive(true);
   }

    public void Resume()
    {
        Time.timeScale = 1f;
        PauseBotton.SetActive(true);
        Pausemenu.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

