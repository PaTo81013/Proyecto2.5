using UnityEngine;

public class MoreTime : MonoBehaviour
{
    [SerializeField] GameObject GameManager;
  
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("balon"))
        {
            Destroy(gameObject);
            GameManager.GetComponent<GameManager>().IncreaseTime(2);
        }
    }

}
