using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coli : MonoBehaviour
{
    public int k = 10;

    public void OnCollisionEnter()
    {
        Debug.Log("True");
        k = k - 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
