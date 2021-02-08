using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyH : MonoBehaviour
{
    public float a;
    public float b;

    public int speedEnemy;

    private void Update()
    {
        ///<summary>
        ///Движение врага в правую сторону.
        ///</summary>
        transform.Translate(Vector2.right * speedEnemy * Time.deltaTime);

        ///<summary>
        ///Если враг дойдет до точки a/b, то он поварачивает в противоположную сторону.
        ///</summary>
        if (transform.position.x <= a)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (transform.position.x >= b)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }

}

