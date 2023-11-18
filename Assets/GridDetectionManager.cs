using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDetectionManager : MonoBehaviour
{
    public Collider2D collider;
    public GameObject visual;
    public FlowerDotsManager flowerDotsManager;
    public LayerMask gridLayer;
    public Collider2D[] grids;

    bool isDragging;

    private void Start()
    {
        flowerDotsManager = FlowerDotsManager.instance;
        collider.enabled = false;
        visual.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            collider.enabled = true;
            visual.SetActive(true);
            isDragging = true;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
            transform.position = mousePos;
        }
        else
        {
            visual.SetActive(false);
            collider.enabled = false;
            isDragging = false;
        }
    }

    private void OnDrawGizmos()
    {
        // Visualize the circle overlap when the object is being dragged
        if (isDragging)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, 0.2f);
        }
    }

    private void FixedUpdate()
    {
        if (isDragging)
        {
            Collider2D[] _grids = Physics2D.OverlapCircleAll(transform.position, 0.2f, gridLayer);
            grids = _grids;
        }
    }
}
