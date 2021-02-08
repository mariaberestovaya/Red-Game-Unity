using UnityEngine;

public class PlayerLevels : PlayerController
{
    public GameObject respawn;

    public override void Die()
    {
        transform.position = respawn.transform.position;
    }
}
