using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShaderExample : MonoBehaviour
{
    public GameObject riverWater;
    private Renderer rend;
    public Color setColor = Color.yellow;
    // Start is called before the first frame update
    void Start()
    {
        rend = riverWater.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.SetColor("Color_681b21f6f88f4037a25cd3e565b91345", setColor);
    }
}
