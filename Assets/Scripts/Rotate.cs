
using UnityEngine;

public class Rotate : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void rotating(float value)
    {
        
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z = value;
        transform.eulerAngles = newRotation;
    }

    public void setScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
