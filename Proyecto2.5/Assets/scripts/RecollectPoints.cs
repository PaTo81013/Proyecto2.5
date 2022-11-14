using UnityEngine;
using TMPro;

public class RecollectPoints : MonoBehaviour
{
    [SerializeField] GameObject GameManager;

    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            Destroy(collision.gameObject);
            GameManager.GetComponent<GameManager>().IncreaseScore(1);
        }
    }
}
