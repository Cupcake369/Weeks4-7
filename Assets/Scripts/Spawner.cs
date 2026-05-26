using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public Vector3 spawnposition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame) 
        {
        //spawn the runner
      //  Instantiate(runnerPrefab);


        //spawn as the child of the spawner
    //    Instantiate(runnerPrefab, transform);


        //spawn at a specific position
        Instantiate(runnerPrefab, spawnposition, Quaternion.identity);

        }
    }
}
