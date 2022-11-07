using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
