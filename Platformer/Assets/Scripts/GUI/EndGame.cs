using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject levels;
    public GameObject play;
    public GameObject house;
    public GameObject pause;
    public GameObject restart;

    private void Start()
    {
        levels.SetActive(false);
        restart.SetActive(false);
        house.SetActive(false);
        play.SetActive(false);
    }
    //Summer
    public void House_Summer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Levels_Summer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Start_Summer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    //August
    public void Start_August()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void House_August()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Levels_August()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PauseButton()
    {
        Time.timeScale = 0;
        levels.SetActive(true);
        restart.SetActive(true);
        house.SetActive(true);
        play.SetActive(true);
    }
    public void Play()
    {
        Time.timeScale = 1;
        levels.SetActive(false);
        restart.SetActive(false);
        house.SetActive(false);
        play.SetActive(false);
    }


}
