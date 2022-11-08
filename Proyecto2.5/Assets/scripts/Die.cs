using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    [SerializeField] private GameObject _playerDie;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            Destroy(gameObject);
            _playerDie.SetActive(true);
        }
    }
}

