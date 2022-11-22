using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    [SerializeField] public GameObject _effect = null;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            var newEffect = Instantiate(_effect, transform.position, Quaternion.identity);
            Destroy(newEffect, 2);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
