using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBoss : MonoBehaviour
{
    public string dieSceneName = "RestartScene";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("Boss"))
        {
            LoadDieScene();
        }
    }

    void LoadDieScene()
    {
        // ‚À≈¥´’π Die
        SceneManager.LoadScene(dieSceneName);

    }

    IEnumerator LoadDieSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(dieSceneName);

        // √Õ®π°«Ë“´’π®–‚À≈¥‡ √Á®
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
