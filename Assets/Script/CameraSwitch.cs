using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera Scene1;
    public Camera Scene2;
    public Camera Scene3;

    private bool isScene1Active = true;
    private bool isScene2Active = true;

    // Start is called before the first frame update
    void Start()
    {
        Scene1.enabled = true;
        Scene2.enabled = false;
        Scene3.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("Next1"))
        {
            isScene1Active = !isScene1Active;

            Scene1.enabled = isScene1Active;
            Scene2.enabled = !isScene1Active;
        }
        else if (collison.gameObject.CompareTag("Next2"))
        {
            isScene2Active = !isScene2Active;

            Scene2.enabled = isScene2Active;
            Scene3.enabled = !isScene2Active;
        }

    }//OnCollisionExit2D
}
