using UnityEngine;

public class treasurespawner : MonoBehaviour
{
    public GameObject treasurePrefab;
    public GameObject treasureOpenPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(treasurePrefab, transform.position, transform.rotation);
    }

     public void Open()
    {
        Instantiate(treasureOpenPrefab, transform.position, transform.rotation);
    }
}
