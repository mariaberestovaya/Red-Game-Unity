using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [Header("Player")]
    public int speed;
    public int jumpForce;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float checkRadius;
    public static int allCoins;
    [HideInInspector]public int _coin;

    private bool _godMod;
    private float _timer;
    private Animator _animator;
    private bool _isFacingRight;
    private Rigidbody2D _rigidbody;
    private bool isGrounded;

    void Start()
    {
        Time.timeScale = 1;
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);//проверка слоя

        //анимация прыжка
        _animator.SetBool("Ground", isGrounded);
        _animator.SetFloat("vSpeed", _rigidbody.velocity.y);

        ///<summary>
        ///Этот скрипт отвечает за двидение персонажа по горизонтали.
        ///</summary>
        float moveX = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(moveX * speed, _rigidbody.velocity.y);

        ///<summary>
        ///Проверка, нужны ли персонажу повороты. Если да, то он поворачивает.
        ///</summary>
        if (moveX > 0 && _isFacingRight)
        {
            Flip();
        }
        else if (moveX < 0 && !_isFacingRight)
        {
            Flip();
        }

        ///<summary>
        ///Анимация бега.
        ///</summary>
        if (moveX == 0)
        {
            _animator.SetBool("Run", false);
        }
        else { _animator.SetBool("Run", true); }

        ///<summary>
        ///Прыжок.
        ///</summary>
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _animator.SetBool("Ground", false);
            _rigidbody.velocity = (Vector2.up * jumpForce);
        }
    }

    /// <summary>
    /// Скрипт для поворота персонажа в противоположную сторону.
    /// </summary>
    private void Flip()
    {
        _isFacingRight = !_isFacingRight;
        transform.Rotate(0F, 180F, 0F);
    }

    public virtual void Die()
    {
            GameObject restart = GameObject.Find("Restart");
            Restart playerController = restart.GetComponent<Restart>();
            GameObject allCoins = playerController.allCoins;
            GameObject pause = playerController.pause;
            GameObject house = playerController.house;
            GameObject restartButton = playerController.restart;
            GameObject coinPerGame = playerController.coinPerGame;

            Time.timeScale = 0;
            restartButton.SetActive(true);
            house.SetActive(true);
            coinPerGame.SetActive(true);
            allCoins.SetActive(false);
            pause.SetActive(false);

            coinPerGame.GetComponent<Text>().text = $"COIN PER GAME = {_coin}";
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            allCoins++;
            _coin++;
            Destroy(other.gameObject);
        }

        else if ((other.tag == "Enemy")||(other.tag == "Restart"))
        {
            Die();
        }
    }

}
