using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public string junho = "Player";
    public int hp = 100;
    public float jumpPower = 8f;
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Transform visual;
    private Vector2 moveInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(junho + "시작.체력" + hp);
        Debug.Log("피격 후 체력"+(hp-50));
        Debug.Log("달리기 속도"+moveSpeed*2);
        Debug.Log("10/4="+10f/4f);
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        if(moveInput.x>0)
        {
            visual.localScale = new Vector3(1, 1, 1);
        }
        else if(moveInput.x < 0)
        {
            visual.localScale = new Vector3(-1, 1, 1);
        }
    }
    void OnJump(InputValue value)
    {
        if(value.isPressed)
        {
            Debug.Log("점프!");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 
                jumpPower);
            {

            }
        }
    }
    void Update()
    {
        Debug.Log("Update");
        transform.Translate(Vector3.right * moveInput.x * moveSpeed * Time.deltaTime);
    }
}
