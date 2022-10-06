using UnityEngine;
public class DestroyPlatform : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("no se");
        if (other.CompareTag("Platform"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
