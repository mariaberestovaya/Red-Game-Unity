using UnityEngine;
using UnityEngine.SceneManagement;
public class Winter : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
