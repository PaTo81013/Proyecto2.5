using UnityEngine;
using UnityEngine.SceneManagement;
public class morir : MonoBehaviour
{
    [SerializeField] private GameObject adios;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Destroy(gameObject);
            adios.SetActive(true);
        }
    }
}

