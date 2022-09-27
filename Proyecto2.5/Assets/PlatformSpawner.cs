using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private Transform _platformStartPosition = null;
    [SerializeField] private Transform _platformParent = null;
    [SerializeField] private GameObject _platformPrefab = null;
    [SerializeField] private float _spawnInterval = 0.5f;

    private void Start()
    {
        StartCoroutine("PlataformasInfinitos");
    }

    private IEnumerator PlataformasInfinitos()
    {
       while(true)
       {
          
            Instantiate(_platformPrefab, _platformStartPosition.position, Quaternion.identity, _platformParent);
            yield return new WaitForSeconds(_spawnInterval);
       }
    }
}
