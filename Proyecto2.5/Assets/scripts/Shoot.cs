using System.Collections;
using UnityEngine;
using DG.Tweening;
public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullets = null;
    [SerializeField] private Transform _direction = null;
    [SerializeField] private float _amountbullets = 10f;
    [SerializeField] private float _scaleobject = 1.62f;
    [SerializeField] private float _cooldown;
    [SerializeField] private bool _shootornot;
    [SerializeField] private AudioClip _shoot;
    public void Shoots()
    {
        if (_shootornot)
        {
            var sequence = DOTween.Sequence();
            sequence.Append(transform.DOPunchScale(new Vector3(0, -1f, 0), 1, 1));
            // sequence.AppendCallback(ChangeScale);
            transform.localScale = new Vector3(_scaleobject, _scaleobject, 0);
            AudioManager.instance.PlaySFX(_shoot);
            Instantiate(_bullets, _direction.position, Quaternion.identity);
            _shootornot = false;
        }
        else
        {
            StartCoroutine("Reload");
        }
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        _shootornot = true;
    }

    private void ChangeScale()
    {
        if (transform.localScale.y < 1.62)
        {
            transform.localScale = new Vector3(0, _scaleobject, 0);
        }
    }
}
