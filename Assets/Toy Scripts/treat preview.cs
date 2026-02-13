
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class treatpreview : MonoBehaviour
{
    public TextMeshProUGUI size;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        size.text = slider.value.ToString();
    }

     public void BigTreat(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
