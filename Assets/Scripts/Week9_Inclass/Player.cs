using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject hole;
    public GameObject chest;
    public GameObject UI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToMove = new Vector3(0, 0, 0); //this is the constructor for vector3
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            directionToMove.x -= 1f;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            directionToMove.x += 1f;
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            directionToMove.y += 1f;
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            directionToMove.y -= 1f;
        }
        transform.position += directionToMove * speed * Time.deltaTime;
    }
    public void Openchest()
    {
       hole.SetActive(true);
        gameObject.SetActive(false);
        chest.SetActive(false);
        UI.SetActive(true);
    }
    public void ResetButton() 
    {
        hole.SetActive(false);
        gameObject.SetActive(true);
        transform.position = new Vector3(0, 0, 0);
        chest.SetActive(true);
        UI.SetActive(false);
    }
}
