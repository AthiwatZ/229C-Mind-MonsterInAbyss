using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtime : MonoBehaviour
{
    public string nextSceneName = "Menu"; // ชื่อ Scene หลักที่จะเปลี่ยนไป
    public float displayTime = 15f; // เวลาแสดง 15 วินาที

    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    IEnumerator LoadSceneAfterDelay()
    {
        
        yield return new WaitForSeconds(displayTime);

        if (Application.CanStreamedLevelBeLoaded(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            Debug.LogError("Scene not found: " + nextSceneName);
        }
    }
}
