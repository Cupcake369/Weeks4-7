using UnityEngine;

public class Hider : MonoBehaviour
{
    public Vector3 hiddenPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Hide()
    {
        transform.position = hiddenPosition;
    }
}
