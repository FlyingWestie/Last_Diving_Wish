using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuMainScript : MonoBehaviour
{

    public AudioClip airplane_pa;
    public AudioSource soundSource;

    public static object LocalizationManager { get; private set; }

    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        soundSource.Play();
        StartCoroutine(WaitAndLoadScene(soundSource.clip.length));
    }
        private IEnumerator WaitAndLoadScene(float length)
        {
            float duration = soundSource.clip.length;
            soundSource.PlayOneShot(soundSource.clip);
     
            AsyncOperation sceneLoading = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
            sceneLoading.allowSceneActivation = false;
     
            yield return new WaitForSeconds(1);

            while (sceneLoading.progress < 0.9f) yield return null;

            sceneLoading.allowSceneActivation = true;
        }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
