using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoAnimationEvents : MonoBehaviour
{
    public void OnLogoAnimationFinish(int id)
    {
        //TODO: replace this with a call to the initialization scene.
        SceneManager.LoadScene("MainMenuScene");

    }

    public void PlayLogoSound()
    {
        this.GetComponent<AudioSource>().Play();
    }
}
