using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_Tank : MonoBehaviour
{
    //speed of the tank
    public int speed;

    public Camera camera;
    public bool onScreen;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftkeypressed = Keyboard.current.leftArrowKey.isPressed; 
        bool rightkeypressed = Keyboard.current.rightArrowKey.isPressed;
        bool downkeypressed = Keyboard.current.downArrowKey.isPressed;
        bool upkeypressed = Keyboard.current.upArrowKey.isPressed;
        Vector3 currentpos =  transform.position;
        int screenWidth = Screen.width;
         
        if (screenWidth > currentpos.x) 
        { 
        onScreen = true;
        Debug.Log("On Screen");
        }
        else
        {
            onScreen = false;
            Debug.Log("Off Screen");

        }


        //for left keypressed, move left
        if (leftkeypressed == true)
        {
            Vector3 moveleft = transform.position;
            moveleft += Vector3.left * speed * Time.deltaTime;
            moveleft.z = 0;
            transform.position = moveleft;
        }

        //for right keypressed, move right
        if (rightkeypressed == true)
        {
            Vector3 moveRight = transform.position;
            moveRight += Vector3.right * speed * Time.deltaTime;
            moveRight.z = 0;
            transform.position = moveRight;
        }

        //for up keypressed, move up
        if (upkeypressed == true)
        {
            Vector3 moveUp = transform.position;
            moveUp += Vector3.up * speed * Time.deltaTime;
            moveUp.z = 0;
            transform.position = moveUp;
        }

        //for down keypressed, move down
     
        if (downkeypressed == true)
        {
            Vector3 moveDown = transform.position;
            moveDown += Vector3.down * speed * Time.deltaTime;
            moveDown.z = 0;
            transform.position = moveDown;
        }

    }
}
