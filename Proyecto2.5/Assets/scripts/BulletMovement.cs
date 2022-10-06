using UnityEngine;
public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float Velocity=4f;

    void Update()
    {
        transform.Translate(Vector3.up*Velocity*Time.deltaTime);  
    }
}
