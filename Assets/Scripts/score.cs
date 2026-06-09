using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //public Slider scoreSlider;
    public TMP_Text currentScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public void onSliderChange(float scoreValue) 
    {
        // Debug.Log(scoreSlider.value);
        // currentScoreText.text = "Score: " + scoreSlider.value;
        Debug.Log(scoreValue);
        currentScoreText.text = "Score: " + scoreValue;
    }
}
