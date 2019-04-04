using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    public Text timerText;
    public Text back;
    public Button backButton;

    private Rigidbody rb;
    private int count;
    private float timer;
    private bool stopFlag;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        timer = 0;
        SetCountText();
        winText.text = "";
        timerText.text = "Time : 0.00 s";
        stopFlag = false;
        back.text = "Menu";
        backButton.gameObject.SetActive(false);
    }

    void Update()
    {
        if (!stopFlag)
        {
            timer += Time.deltaTime;
            timerText.text = "Time : " + timer.ToString("0.00") + " s";
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0 , moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("PickUp"))
        {
            count++;
            SetCountText();
            col.gameObject.SetActive(false);
        }
        if (col.gameObject.CompareTag("Walls"))
        {
            stopFlag = true;
            winText.text = "You Lose!";
            backButton.gameObject.SetActive(true);
            gameObject.transform.position = new Vector3(0, 0.5f, 0);
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    void SetCountText()
    {
        countText.text = "Pick ups : " + count.ToString();

        if(count >= 8)
        {
            stopFlag = true;
            winText.text = "You Win!";
            backButton.gameObject.SetActive(true);
            gameObject.transform.position = new Vector3(0, 0.5f, 0);
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
