using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject brickPrefab;
    public int rows = 5;
    public int columns = 10;
    public float spacing = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        Vector2 startPos = (Vector2)transform.position - new Vector2((columns - 1) * (brickPrefab.transform.localScale.x + spacing) / 2, 0);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Vector2 brickPos = startPos + new Vector2(col * (brickPrefab.transform.localScale.x + spacing), -row * (brickPrefab.transform.localScale.y + spacing));
                GameObject newBrick = Instantiate(brickPrefab, brickPos, Quaternion.identity);
                newBrick.transform.parent = transform;
            }
        }
    }
}
