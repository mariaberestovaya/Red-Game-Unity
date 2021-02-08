using UnityEngine.UI;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject allCoins;
    public GameObject pause;
    public GameObject coinPerGame;
    public GameObject restart;
    public GameObject house;

    private void Start()
    {
        restart.SetActive(false);
        house.SetActive(false);
        coinPerGame.SetActive(false);
    }
}
