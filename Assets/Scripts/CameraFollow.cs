using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = player.position - offset;
        targetPos.x = 0;
        targetPos.y = transform.position.y;
        transform.position = targetPos;
    }

}
