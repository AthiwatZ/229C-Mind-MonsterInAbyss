using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public string dieSceneName = "RestartScene";

    public string chooseSceneName = "ChooseWeaponScene";

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("Boss"))
        {
            LoadDieScene();
        }
        else if (collison.gameObject.CompareTag("Chest"))
        {
            LoadWeaponScene();
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

    void LoadWeaponScene()
    {
        SceneManager.LoadScene(chooseSceneName);
    }

    IEnumerator LoadWeaponSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(chooseSceneName);

        // √Õ®π°«Ë“´’π®–‚À≈¥‡ √Á®
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
