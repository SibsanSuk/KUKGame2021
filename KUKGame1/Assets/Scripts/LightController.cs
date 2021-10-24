using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        print("Mouse Down");
        light.enabled = !light.enabled;
        light.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        light.intensity = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
