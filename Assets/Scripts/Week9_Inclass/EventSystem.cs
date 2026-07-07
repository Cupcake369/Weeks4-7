using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class EventSystem : MonoBehaviour
{
    public SpriteRenderer trapRenderer;
    public Player player;

    public UnityEvent onTrapEntered;
    public UnityEvent onTrapExited;
    bool isCurrentlyonTrap = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trapRenderer.bounds.Contains(player.transform.position) && !isCurrentlyonTrap && Keyboard.current.spaceKey.isPressed)
        {
            onTrapEntered.Invoke();
            isCurrentlyonTrap = true;

        }
        if (!trapRenderer.bounds.Contains(player.transform.position) && isCurrentlyonTrap)
        {
            onTrapExited.Invoke();
            isCurrentlyonTrap = false;
        }
    }
}
