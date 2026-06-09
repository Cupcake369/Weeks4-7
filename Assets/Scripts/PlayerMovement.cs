using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    public GameObject pillar;
    public Image image;
    public float distanceBetweentwo = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       bool isLeftkeypressed = Keyboard.current.leftArrowKey.isPressed;
       bool isRightkeypressed = Keyboard.current.rightArrowKey.isPressed;
       bool isUpkeypressed = Keyboard.current.upArrowKey.isPressed;
       bool isDownkeypressed = Keyboard.current.downArrowKey.isPressed;


        Vector3 currentpos = transform.position;
        currentpos.z = 0;
        if (isLeftkeypressed)
        {
            currentpos += Vector3.left * speed * Time.deltaTime;
            transform.position = currentpos;
        }
        if (isRightkeypressed)
        {
            currentpos += Vector3.right * speed * Time.deltaTime;
            transform.position = currentpos;
        }
        if (isUpkeypressed)
        {
            currentpos += Vector3.up * speed * Time.deltaTime;
            transform.position = currentpos;
        }
        if (isDownkeypressed)
        {
            currentpos += Vector3.down * speed * Time.deltaTime;
            transform.position = currentpos;
        }

        float Distance = Vector3.Distance(transform.position, pillar.transform.position);
        if (Distance <= distanceBetweentwo) 
        { 
        
        image.gameObject.SetActive(true);

        }
        else
        {
            image.gameObject.SetActive(false);
        }

    }
}
