using UnityEngine;
using UnityEngine.SceneManagement;

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
            Application.OpenURL("https://yourgame.itch.io/"); 
    #else
        Application.Quit();
    #endif
    }

}
