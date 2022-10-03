using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientobala : MonoBehaviour
{
    [SerializeField] private float velocidad=4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*velocidad*Time.deltaTime);
        
    }
}
