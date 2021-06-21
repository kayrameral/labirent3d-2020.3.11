using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject Sphere;
    Vector3 offset;
    private void Start()
    {
        offset = transform.position - Sphere.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = Sphere.transform.position + offset;
    }
}
