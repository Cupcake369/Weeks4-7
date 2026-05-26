using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class Trainer : MonoBehaviour
{
    public SpriteRenderer creatureRenderer;
    public Camera gameCamera;
    public Color caughtColor;

    public List<SpriteRenderer> uncaughtCreatures;
    public List<SpriteRenderer> iscaughtCreatures;

    public Hider creatureHider; // Reference to the Hider script


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isClicked = Mouse.current.leftButton.wasPressedThisFrame;
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldPos = gameCamera.ScreenToWorldPoint(mousePos);
        worldPos.z = 0;


        if (isClicked)
        {

            for (int i = 0; i < iscaughtCreatures.Count; i++) 
            {
                Debug.Log(iscaughtCreatures[i]);
            }




            if (iscaughtCreatures.Count > 0) 
            {
                Debug.Log(iscaughtCreatures[0]);
            }
          
        }






        if (isClicked && creatureRenderer.bounds.Contains(worldPos))
        {
         
            creatureRenderer.color = caughtColor;
            //This checks if the caughtCreatures list already contains the creatureRenderer. If it does not contain it, then it will add it to the list.
            //! means false
           
            if (!iscaughtCreatures.Contains(creatureRenderer)) 
            {
                creatureHider.Hide(); // Call the Hide method from the Hider script to hide the creature
                iscaughtCreatures.Add(creatureRenderer); // this will add the caught creature to the list of (caughtCreatures)
               
            }

            
            uncaughtCreatures.Remove(creatureRenderer); // this will remove the caught creature from the list of (uncaughtCreatures)
        }
    }
}
