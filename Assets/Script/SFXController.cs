using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    public static SFXController instance;

    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip buttonClick;

    [SerializeField]
    private AudioClip throwFood;

    private void Awake()
    {
        instance = this;
    }

    public void ButtonClick()
    {
        audioSource.PlayOneShot(buttonClick);
    }

    public void ThrowFood()
    {
        audioSource.PlayOneShot(throwFood);
    }
}
