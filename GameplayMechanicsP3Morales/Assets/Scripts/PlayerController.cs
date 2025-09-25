using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint; 
    public float speed = 5.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        // Focal point is in the scene, so GameObject.Find can be used instead of GetComponent
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        // Makes player movement corrolate to the position of the camera (focal point). It always goes forward from camera.
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
