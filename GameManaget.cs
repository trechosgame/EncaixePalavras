using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManaget : MonoBehaviour
{
    public Puzzle puzzlePrefab;

    private List<Puzzle> puzzleList = new List<Puzzle>();
    // 
    private Vector2 startPosition = new Vector2(-3.55f, 1.77f);
    private Vector2 offset = new Vector2(2.03f, 1.52f);
    void Start()
    {
        SpawnPuzzle(14);
        SetStartPosition();
    }

    // 
    void Update()
    {

    }

    private void SpawnPuzzle(int number)
    {
        for (int i = 0; i <= number; i++)
        {
            puzzleList.Add(Instantiate(puzzlePrefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity) as Puzzle);
        }
    }

    private void SetStartPosition()
    {
        //first line
        puzzleList[0].transform.position = new Vector3(startPosition.x, startPosition.y, 0.0f);
        puzzleList[1].transform.position = new Vector3(startPosition.x + offset.x, startPosition.y, 0.0f);
        puzzleList[2].transform.position = new Vector3(startPosition.x + (2 * offset.x), startPosition.y, 0.0f);

        //second line
        puzzleList[3].transform.position = new Vector3(startPosition.x, startPosition.y - offset.y, 0.0f);
        puzzleList[4].transform.position = new Vector3(startPosition.x + offset.x, startPosition.y - offset.y, 0.0f);
        puzzleList[5].transform.position = new Vector3(startPosition.x + (2 * offset.x), startPosition.y, 0.0f);
        puzzleList[6].transform.position = new Vector3(startPosition.x + (3 * offset.x), startPosition.y, 0.0f);

        //third line
        puzzleList[7].transform.position = new Vector3(startPosition.x, startPosition.y - (2 * offset.y), 0.0f);
        puzzleList[8].transform.position = new Vector3(startPosition.x + offset.x, startPosition.y - (2 * offset.y), 0.0f);
        puzzleList[9].transform.position = new Vector3(startPosition.x + (2 * offset.x), startPosition.y - (2 * offset.y), 0.0f);
        puzzleList[10].transform.position = new Vector3(startPosition.x + (3 * offset.x), startPosition.y - (2 * offset.y), 0.0f);
        
        //fourth line
        puzzleList[11].transform.position = new Vector3(startPosition.x, startPosition.y - (2*offset.y), 0.0f);
        puzzleList[12].transform.position = new Vector3(startPosition.x + offset.x, startPosition.y - (2 * offset.y) , 0.0f);
        puzzleList[13].transform.position = new Vector3(startPosition.x + (2 * offset.x), startPosition.y - (2 * offset.y), 0.0f);
        puzzleList[14].transform.position = new Vector3(startPosition.x + (3 * offset.x), startPosition.y - (2 * offset.y), 0.0f);
    }
}

