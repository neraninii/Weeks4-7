using System.Collections.Generic;
using UnityEngine;

public class treatspawner : MonoBehaviour
{
     //Initializing Variables
    public GameObject applePrefab;
    public GameObject carrotPrefab;

    public int appleNumber = 0;
    public int carrotNumber = 0;

    public GameObject SpawnedApple;
    public GameObject SpawnedCarrot; 

    public treatmovement treatmovement;

    public List<GameObject> apples;
    public List<GameObject> carrots;

    public Transform horsiepie;

    public float Ct = 0; 
    public float At = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //For loop to track the carrots in the list to initiate destroying if it has spawned
        for(int j = carrots.Count - 1; j >=0; j--)
        {
            //Calculating the carrot's distance against the horse's 
            float distanceCarrot = Vector2.Distance(carrots[j].transform.position, horsiepie.position);

            //Starting timer
            Ct += Time.deltaTime;

            //Destroying carrot and removing it from the list if it has hit the horse
            if (distanceCarrot < 1.5f)
            {
                Debug.Log("carrot ate" + j);
                GameObject carrot = carrots[j];
                carrots.Remove(carrot);
                Destroy(carrot);
            }

            //Timing out the carrot and destroying it if it has missed the horse or been rotating for too long
            if (Ct > 10)
            {
                Debug.Log("carrot timed out" + j);
                GameObject carrot = carrots[j];
                carrots.Remove(carrot);
                Destroy(carrot);

                //restarting timer
                Ct = 0;
            }
        }

        //For loop to track the apples in the list to initiate destroying if it has spawned
         for (int i = apples.Count - 1; i >= 0; i--)
        {
            //Calculating the apple's distance against the horse's 
            float distanceApple = Vector2.Distance(apples[i].transform.position, horsiepie.position);

            //Starting timer
            At += Time.deltaTime;

            //Destroying apple and removing it from the list if it has hit the horse
            if (distanceApple < 2f)
            {
                Debug.Log("apple ate" + i);
                GameObject apple = apples[i];
                apples.Remove(apple);
                Destroy(apple);

            }

            //Timing out the apple and destroying it if it has missed the horse or been rotating for too long
            if (At > 5)
            {
                Debug.Log("apple timed out" + i);
                GameObject apple = apples[i];
                apples.Remove(apple);
                Destroy(apple);

                //restarting timer
                At = 0;
            }
        }

    }

    //Function to spawn the apple treat
    public void AppleSpawn()
    {
        //Spawning the Apple as a prefab + adding it to the list to keep track of
        SpawnedApple = Instantiate(applePrefab, transform.position, transform.rotation);

        treatmovement = SpawnedApple.GetComponent<treatmovement>();

        appleNumber += 1;

        apples.Add(SpawnedApple);
       
    }
    
    //Function to spawn the carrot treat
    public void CarrotSpawn()
    {
        //Spawning the Apple as a prefab + adding it to the list to keep track of
        SpawnedCarrot = Instantiate(carrotPrefab, transform.position, transform.rotation);

        treatmovement = SpawnedCarrot.GetComponent<treatmovement>();

        carrotNumber += 1; 

        carrots.Add(SpawnedCarrot);

    }

    
}
