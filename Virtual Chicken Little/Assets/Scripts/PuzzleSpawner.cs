using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSpawner : MonoBehaviour
{
    public GameObject[] puzzles;
    public float xbound1, xbound2, ybound;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomPuzzle());
    }

    IEnumerator SpawnRandomPuzzle() 
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomPuzzle = Random.Range(0, puzzles.Length);

        if(Random.value <= .6f) {
            Instantiate(puzzles[randomPuzzle],
            new Vector2(Random.Range(xbound1, xbound2),
                ybound), Quaternion.identity);
        }

        StartCoroutine(SpawnRandomPuzzle());
    }
}
