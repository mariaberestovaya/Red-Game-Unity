using UnityEngine.UI;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Update()
    {
        int allCoins = PlayerController.allCoins;
        GetComponent<Text>().text = $"{allCoins} coin";
    }
}
