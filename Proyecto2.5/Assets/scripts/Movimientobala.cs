using UnityEngine;
public class Movimientobala : MonoBehaviour
{
    [SerializeField] private float velocidad=4f;
    void Update()
    {
        transform.Translate(Vector3.up*velocidad*Time.deltaTime);  
    }
}
