using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10;
    public bool isOnGround = false;

    public bool isGameover = false;

    public AudioClip jumpSound;

    public GameObject PlayerFX;
    public AudioClip crashSound;

    private Rigidbody2D _playerRB;
    private Animator _playerAnim;

    private GameManager _gameManager;
    private AudioSource _playerAudio;
    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
      //  _playerAnim = GetComponent<Animator>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameover)
        {
            _playerRB.velocity = new Vector2(_playerRB.velocity.x, jumpForce);
            isOnGround = false;
          //  _playerAnim.SetBool("IsOnGround", false);
             _playerAudio.PlayOneShot(jumpSound, 1.0f);

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
          //  _playerAnim.SetBool("IsOnGround", true);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            _gameManager.GameOver();
            gameObject.SetActive(false);
            Instantiate(PlayerFX, transform.position, PlayerFX.transform.rotation);
            
            
           // _playerAnim.SetTrigger("isHit");
           // _playerAudio.PlayOneShot(crashSound, 1.0f);
        }
        if (other.gameObject.CompareTag("Win"))
        {
            _gameManager.Win();
            Destroy(this.gameObject);
        }
    }
}