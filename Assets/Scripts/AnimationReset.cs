using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationReset : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CreditsBack());
    }

    IEnumerator CreditsBack()
    {
        yield return new WaitForSeconds(34);
        SceneManager.LoadScene(0);
    }

}