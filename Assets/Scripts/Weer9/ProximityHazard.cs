using UnityEngine;
using UnityEngine.Events;

public class ProximityHazard : MonoBehaviour
{
    public SpriteRenderer trapRenderer;
    public Explorer explorer;

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
        if (trapRenderer.bounds.Contains(explorer.transform.position) && !isCurrentlyonTrap)
        {
           onTrapEntered.Invoke();
            isCurrentlyonTrap = true;

        }
        if (!trapRenderer.bounds.Contains(explorer.transform.position) && isCurrentlyonTrap)
        {
            onTrapExited.Invoke();
            isCurrentlyonTrap = false;
        }
    }
}
