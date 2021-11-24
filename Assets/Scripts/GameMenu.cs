using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
        public GameObject Menu;
        public GameObject gOptions;

        private void Update()
        {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Settings();
        }
        }
        public void ReloadGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
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
                Menu.SetActive(!Menu.activeInHierarchy);
                Time.timeScale = 0;
            if (Menu == false)
            {
                Time.timeScale = 1;
            }
        }

        public void Resume()
        {
            Menu.SetActive(!Menu.activeInHierarchy);
            Time.timeScale = 1;
        }
}
