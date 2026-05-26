using UnityEngine;

public class RotateClockHand : MonoBehaviour
{
    public float roationSpeed = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.z += roationSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }
}
