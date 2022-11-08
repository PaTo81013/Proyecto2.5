using UnityEngine;

public class DestroyWhenItTouch : MonoBehaviour
{
    [SerializeField] private GameObject _destroyball;
  
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag ("Floor"))
        {
            Destroy(gameObject);
        }

    }
}
