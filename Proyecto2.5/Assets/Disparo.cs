using System.Collections;
using System.Collections.Generic;
using Mono.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] private GameObject bala;
    [SerializeField] private Transform direccion;
    [SerializeField] private float cantidad_de_balas = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (cantidad_de_balas > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {

                Instantiate(bala, direccion.position, Quaternion.identity);
                cantidad_de_balas--;
            }
        }
        else
        {
            StartCoroutine("Recargar");
        }
    }



    private IEnumerator Recargar()
    {
        yield return new WaitForSeconds(2);
        cantidad_de_balas = 10;
    }

}
