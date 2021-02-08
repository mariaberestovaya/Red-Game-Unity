using UnityEngine;

class EnemyBrain : MonoBehaviour
{
    private GameObject _player;
    public float speedMoveX = 1.0f;
    public float speedMoveY = 1.0f;
    public float maxDistance = 10;
    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        float directionX = _player.transform.position.x - transform.position.x;
        float directionY = _player.transform.position.y - transform.position.y;

        if (Mathf.Abs(directionX) < maxDistance)
        {
            Vector3 pos = transform.position;
            pos.x += Mathf.Sign(directionX) * speedMoveX * Time.deltaTime;
            pos.y += Mathf.Sign(directionY) * speedMoveY * Time.deltaTime;
            transform.position = pos;
        }
    }
}
