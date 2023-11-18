using UnityEngine;
using UnityEditor;

public class GridGenerator : MonoBehaviour
{
    public int xCount = 5; // Number of cells along the x-axis
    public int yCount = 5; // Number of cells along the y-axis

    public GameObject cellPrefab; // Prefab to use as a grid cell

    public float cellWidth = 1f; // Width of each cell
    public float cellHeight = 1f; // Height of each cell
    public void GenerateGrid()
    {
        ClearGrid(); // Clear existing grid before generating a new one


        float totalWidth = xCount * cellWidth; // Total width of the grid
        float totalHeight = yCount * cellHeight; // Total height of the grid

        // Calculate the starting position for the top-left cell to ensure the parent is at the center
        Vector3 startingPosition = new Vector3(-totalWidth / 2f + cellWidth / 2f, totalHeight / 2f - cellHeight / 2f, 0f);

        for (int y = 0; y < yCount; y++) // Start from yCount - 1 to 0
        {
            for (int x = 0; x < xCount; x++)
            {
                Vector3 cellPosition = startingPosition + new Vector3(x * cellWidth, -y * cellHeight, 0f); // Calculate cell position from top-left to bottom-right

                // Instantiate a cellPrefab at the calculated position
                GameObject newCell = Instantiate(cellPrefab, cellPosition, Quaternion.identity);
                newCell.name = x.ToString()+ "/" + y.ToString();
                newCell.transform.parent = transform; // Set the parent of the cell to this GameObject
            }
        }
    }


    public void ClearGrid()
    {
        // Destroy all child objects (cells) of this GameObject
        foreach (Transform child in transform)
        {
            DestroyImmediate(child.gameObject);
        }
    }
}
