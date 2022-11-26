using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    [SerializeField] public GameObject _effect = null;
    [SerializeField] private AudioClip _destroySound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            var newEffect = Instantiate(_effect, transform.position, Quaternion.identity);
            Destroy(newEffect, 2);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySFX(_destroySound);
            Destroy(gameObject);
        }
    }
}
