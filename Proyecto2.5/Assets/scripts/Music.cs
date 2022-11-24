using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioClip _Menu;
   
    void Start()
    {
        AudioManager.instance.PlayMusic(_Menu);
    }
}
