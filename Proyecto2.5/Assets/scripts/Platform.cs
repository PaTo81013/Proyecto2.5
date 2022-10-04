using UnityEngine;
public class Platform : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _deathLimit = -10;
    void Update()
    {
        var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y < _deathLimit)
        {
            Destroy(gameObject);
        }
    }
}
