using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)

    {
        Debug.Log("Hit");

        if (other.CompareTag("Platform"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
