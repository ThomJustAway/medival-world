using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform world;
    [SerializeField] private float speed;

    [SerializeField] private float height;
    [SerializeField] private float distance;

    private void Start()
    {
        //this is to shift to the position that will overlook the entire world
        var newPosition = new Vector3(world.position.x, height, world.position.z + distance);
        transform.position = newPosition;
    }

    private void Update()
    {
        RotateCameraPosition();
        LookAtWorld();
    }

    private void LookAtWorld()
    {
        transform.LookAt(world.position);
    }


    private void RotateCameraPosition()
    {
        float angle = 15;
        transform.RotateAround(world.position, Vector3.up, angle * speed * Time.deltaTime);
        //transform.Rotate();
    }
}
