using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody playerMovement; 
    [SerializeField] float forwardForce = 1000f; 
    [SerializeField] float sideWaysForce = 1000f;
    public float jumpForce = 5000f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    { 
        playerMovement.AddForce(0,0,forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Move Left");
            playerMovement.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Move Right");
            playerMovement.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space) && gameObject.transform.position.y <= 1.1f)
        {
            Debug.Log("Move up");
            playerMovement.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        } 
        if(playerMovement.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
