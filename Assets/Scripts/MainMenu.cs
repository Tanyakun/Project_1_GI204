using System.Collections;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void BacktoLobby()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Quit()
    {
    #if UNITY_WEBGL && !UNITY_EDITOR
        Application.OpenURL("https://tonklazoo.itch.io/"); 
    #else
        Application.Quit();
    #endif
    }

    public void GotToCredits()
    {
        StartCoroutine(TransferToCredits());
    }

    IEnumerator TransferToCredits()
    {
        yield return new WaitForSeconds(0);
        SceneManager.LoadSceneAsync(2);
    }

}
