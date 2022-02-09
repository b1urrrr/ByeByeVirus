using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingZeeto : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab;


    public void setFloatingZeeto()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFloatingZeeto()
    {
        float angle = Random.Range(0f, 360f);
        Vector3 spawnPos = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f);


    }
}
