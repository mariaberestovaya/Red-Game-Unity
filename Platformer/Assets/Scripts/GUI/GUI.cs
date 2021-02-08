using UnityEngine;
using UnityEngine.SceneManagement;

public class GUI : MonoBehaviour
{
    //MainMenu
    public void Start_MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Quit_MainMenu()
    {
        Application.Quit();
    }

    //Restart
    public void Restart_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void House_Restart_Summer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    public void House_Restart_August()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //Levels
    public void House_House()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    
    //You win
    public void Start_YouWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}