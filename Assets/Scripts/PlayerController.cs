using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private Vector2 rightwards;
    [SerializeField] private Vector2 leftwards;
    [SerializeField] private Vector2 upwards;
    [SerializeField] private Vector2 downwards;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScene");
            return;
        }

        UpdateMovementAnimation();
    }

    private void UpdateMovementAnimation()
    {
        bool isMoving = true;
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.transform.localEulerAngles = new Vector3(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            playerAnim.transform.localEulerAngles = Vector3.zero;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerAnim.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerAnim.transform.localEulerAngles = new Vector3(0, 0, -180);
        }
        else
        {
            isMoving = false;
        }

        playerAnim.SetBool("walk", isMoving);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(leftwards);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(upwards);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(rightwards);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(downwards);
        }
    }
}
