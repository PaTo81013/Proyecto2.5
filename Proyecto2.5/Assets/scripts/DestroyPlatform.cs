using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("balon"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
