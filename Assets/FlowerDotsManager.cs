using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum FlowerType { 

    None,
    Red,
    Green,
    Blue,
    Violet
}
public class FlowerDotsManager : MonoBehaviour
{

    public static FlowerDotsManager instance;
    public FlowerType currentFlowerType;
    public FlowerDot currentFlowerDotSeleted;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            currentFlowerType = FlowerType.None;
        }
    }
}
