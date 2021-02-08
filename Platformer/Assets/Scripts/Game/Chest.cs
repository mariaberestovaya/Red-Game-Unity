using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public GameObject youWin;
    public GameObject coinPerGame;
    public GameObject allCoin;
    public GameObject pause;
    public GameObject start;
    public GameObject levels;
    public GameObject house;
    public GameObject restart;

    public GameObject textCoinPerGame;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
        coinPerGame.SetActive(false);
        youWin.SetActive(false);
        start.SetActive(false);
        levels.SetActive(false);
        house.SetActive(false);
        restart.SetActive(false);

        pause.SetActive(true);
        allCoin.SetActive(true);
    }

    private void Update()
    {
        GameObject player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();
        float coin = playerController._coin;
        textCoinPerGame.GetComponent<Text>().text = $"COIN PER GAME = {coin}";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            coinPerGame.SetActive(true);
            youWin.SetActive(true);
            start.SetActive(true);
            levels.SetActive(true);
            house.SetActive(true);
            restart.SetActive(true);

            pause.SetActive(false);
            allCoin.SetActive(false);
        }
    }
}
