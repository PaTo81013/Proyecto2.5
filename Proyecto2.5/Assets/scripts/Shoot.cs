using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullets = null;
    [SerializeField] private Transform _direction = null;
    [SerializeField] private float _amountbullets = 10f;

    public void Shoots()
    {
        if (_amountbullets > 0)
        {
            Instantiate(_bullets, _direction.position, Quaternion.identity);
            _amountbullets--;
        }
        else
        {
            StartCoroutine("Reload");
        }
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(2);
        _amountbullets = 10;
    }
}
