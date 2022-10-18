using UnityEngine;
public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float _velocity = 4f;

    void Update()
    {
        transform.Translate(Vector3.up*_velocity*Time.deltaTime);  
    }
}
