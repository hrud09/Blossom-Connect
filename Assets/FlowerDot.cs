using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerDot : MonoBehaviour
{
    public FlowerType type;
    public FlowerDotsManager dotsManager;

    private void Start()
    {
        dotsManager = FlowerDotsManager.instance;
    }


    private void OnMouseDown()
    {
       print(gameObject.name);
       dotsManager.currentFlowerType = type;
    }
}
