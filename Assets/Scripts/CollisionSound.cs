using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public static AudioClip playerCollision;
    private static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerCollision = Resources.Load<AudioClip>("Brick");
        
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        audioSrc.PlayOneShot(playerCollision);
    }
}
