using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazePlayerController : MonoBehaviour
{

    public float speed;
    public Text winText;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Win Target"))
        {
            other.gameObject.SetActive(false);
            winText.text = "You Win!";
        }
    }
}