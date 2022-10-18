using UnityEngine;
using TMPro;
public class RecollectPoints : MonoBehaviour
{
   
    [SerializeField] GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("balon"))
        {
            Destroy(collision.gameObject);
            GameManager.GetComponent<GameManager>().IncreaseScore(1);
        }
    }
}
