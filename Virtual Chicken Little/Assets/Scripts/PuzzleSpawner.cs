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
      StartCoroutine(SpawnRandomPuzzlePieces());
    }

    IEnumerator SpawnRandomPuzzlePieces()
    {
      yield return new WaitForSeconds(Random.Range(1, 4));
      int rPuzzle = Random.Range(0, puzzles.Length);

      if(Random.value <= .5f)
      {
        Instantiate(puzzles[rPuzzle], 
          new Vector2(Random.Range(xbound1, xbound2), ybound), Quaternion.identity);
      }

      StartCoroutine(SpawnRandomPuzzlePieces());
    }
}
