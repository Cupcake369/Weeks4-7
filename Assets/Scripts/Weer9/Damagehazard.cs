using UnityEngine;

public class Damagehazard : MonoBehaviour
{
    public SpriteRenderer playerRenderer;
    public Explorer explorer;
    bool isCurrentlyonTrap = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRenderer.bounds.Contains(transform.position) && !isCurrentlyonTrap)
        {
            explorer.health -= 10;
            isCurrentlyonTrap = true;

        }
        if (!playerRenderer.bounds.Contains(transform.position) && isCurrentlyonTrap)
        {
            isCurrentlyonTrap = false;
        }

    }
}
