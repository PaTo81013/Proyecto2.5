using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    [SerializeField] private GameObject PlayerDie;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
            PlayerDie.SetActive(true);
        }
    }
}

