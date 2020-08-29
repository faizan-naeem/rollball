using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rigidBody.AddForce(new Vector3(horizontalInput, 0.0f, verticalInput) * speed * -1);

    }
}
