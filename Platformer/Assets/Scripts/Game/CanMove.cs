using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMove : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        //положение камеры == положение игрока по x
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
    }
}
