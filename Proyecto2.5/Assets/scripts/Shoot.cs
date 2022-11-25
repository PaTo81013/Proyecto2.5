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
    [SerializeField] private bool _trigger;
    [SerializeField] private GameObject _button;
    public void Shoots()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(transform.DOPunchScale(new Vector3(0, -1f, 0), 1, 1));
        transform.localScale = new Vector3(_scaleobject, _scaleobject, 0);
        AudioManager.instance.PlaySFX(_shoot);
        _button.SetActive(false);
        Instantiate(_bullets, _direction.position, Quaternion.identity);
        StartCoroutine("Reload");
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        _button.SetActive(true);
    }
}
