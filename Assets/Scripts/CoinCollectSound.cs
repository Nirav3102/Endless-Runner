using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectSound : MonoBehaviour
{
    public static AudioClip coinCollect;
    private static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        coinCollect = Resources.Load<AudioClip>("CoinCollect");
        
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSrc.PlayOneShot(coinCollect);
    }
}
