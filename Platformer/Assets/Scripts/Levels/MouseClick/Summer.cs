using UnityEngine;
using UnityEngine.SceneManagement;

public class Summer : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}