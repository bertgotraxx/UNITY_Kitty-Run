using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D RB;
    public Canvas GameOverScreen;
    public bool OnGround;
    public InputAction InputAction;
    private Animator _animator;
    private void OnEnable()
    {
        InputAction.Enable();
    }

    private void OnDisable()
    {
        InputAction.Disable();
    }

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        //BoxCollider2D = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        float jumpInputValue = InputAction.ReadValue<float>();

        //OnGround = Physics2D.CircleCast(transform.position, 0.6f, Vector2.down, 0.01f);
        OnGround = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);

        //Debug.Log(OnGround);

        switch (OnGround)
        {
            case true:
                RB.linearVelocityY = jumpInputValue * 8;
                _animator.SetBool("OnGround", true);
                break;
            case false:
                _animator.SetBool("OnGround", false);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            GameOverScreen.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;

            if (GameObject.Find("ScoreTable").GetComponent<HighScore>().HIGH_SCORE > GameObject.Find("ScoreTable").GetComponent<HighScore>().SCORE) return;
            else SaveSystem.SaveGameData();

            //s

            Destroy(gameObject);
        }
    }
}
