using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public float turnSpeed;
    //hmm
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Moves the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the vehicle
        if (forwardInput != 0 && horizontalInput != 0)
        {
            transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);

        }
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
