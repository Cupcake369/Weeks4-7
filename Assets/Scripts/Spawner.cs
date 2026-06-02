using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public GameObject runnerPrefab;
    public GameObject existingRunner;
    public Vector3 spawnposition;
    public float spawnspeed;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.rightButton.wasPressedThisFrame) 
        {
            Destroy(existingRunner, 3f);


        }
        if (Mouse.current.leftButton.wasPressedThisFrame) 
        {
           
        }

         
    }
    public void OnSpawnPress() {
        //spawn the runner
        //  Instantiate(runnerPrefab);


        //spawn as the child of the spawner
        //    Instantiate(runnerPrefab, transform);


        //spawn at a specific position
        //Instantiate(runnerPrefab, spawnposition, Quaternion.identity);

        GameObject spwanenObject = Instantiate(runnerPrefab, spawnposition, Quaternion.identity);

        SpriteRenderer spawnedSpriteRenderer = runnerPrefab.GetComponent<SpriteRenderer>();
        //spawnedSpriteRenderer.color = Color.red;
        //make the spawn object move at spwan speed
        Runner runnerPrabspeed = runnerPrefab.GetComponent<Runner>();

        if (runnerPrabspeed != null)
        {

            runnerPrabspeed.speed = spawnspeed;

        }



        Destroy(spwanenObject, 3f);


    }
}
