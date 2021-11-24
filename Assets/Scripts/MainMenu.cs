using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public GameObject Menu;
   public GameObject gOptions;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game"); //SceneManager.GetActiveScene().name
    }

    public void QuitGame()
    {
        Debug.Log("See you soon!");
        Application.Quit();
    }

    public void Options()
    {
        Menu.SetActive(!Menu.activeInHierarchy);
        gOptions.SetActive(!gOptions.activeInHierarchy);
    }

    public void Settings()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Menu.SetActive(!Menu.activeInHierarchy);
        }
    }
}
