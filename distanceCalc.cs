using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCalc : MonoBehaviour
{
    public GameObject prefabObject;
    public GameObject cube1;
    public GameObject cube2;

    // Start is called before the first frame update
    void Start()
    {
        //checking if objects aren't null
        if(cube1 != null && cube2 != null && prefabObject != null)
        {
            //calc distance between two objects
            float dist = Vector3.Distance(cube1.transform.position, cube2.transform.position);

            //calc scale based on the distance of two objects
            //Vector3 scale = new Vector3(dist, dist, dist);
            Vector3 scale = cube1.transform.localScale;

            //instantiate new prefab object at midpoint between cube1 and cube2
            Vector3 midPoint = (cube1.transform.position + cube2.transform.position) / 2f;
            GameObject cube3 = Instantiate(prefabObject, midPoint, Quaternion.identity);

            //setting scale of cube3
            cube3.transform.localScale = scale;

            //displaying distance between two cubes
            Debug.Log("Distance between cube1 and cube2: " + dist);
        }
        else
        {
            Debug.LogError("One or more GameObjects or prefabObjects are null!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
