using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharngeRotate : MonoBehaviour
{
    public Vector3 newRotationEuler = Vector3.zero;
    public Vector3 newScale = Vector3.one;

    void Start()
    {
        transform.rotation = Quaternion.Euler(newRotationEuler);
        transform.localScale = newScale;
    }
}
