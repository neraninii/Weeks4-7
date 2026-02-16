
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class treatpreview : MonoBehaviour
{
     //Initializing Variables
    public TextMeshProUGUI size;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Having the slider value show as a number on screen
        size.text = slider.value.ToString();
    }

    //Function to change the preview treat's scale
     public void BigTreat(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
