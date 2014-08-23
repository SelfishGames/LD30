using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{
    public Transform player;

    private Vector3 tempPos;

    void Start()
    {
        tempPos = transform.position;
    }

    void Update()
    {
        tempPos.x = player.position.x;
        transform.position = tempPos;
    }
}
