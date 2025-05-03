using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTranforms : MonoBehaviour
{
    public Vector3 newRotationEuler = Vector3.zero;
    public Vector3 newScale = Vector3.one;
    public Vector3 newPosition = Vector3.zero;

    void Start()
    {
        transform.rotation = Quaternion.Euler(newRotationEuler);
        transform.localScale = newScale;
        transform.localPosition = newPosition;
    }
}
