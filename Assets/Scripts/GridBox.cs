using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBox : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0)) {

            if (FlowerDotsManager.instance.currentFlowerType == FlowerType.Green) { 
            
                GetComponent<SpriteRenderer>().color = Color.green;

            }
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

           
        }
    }
}
