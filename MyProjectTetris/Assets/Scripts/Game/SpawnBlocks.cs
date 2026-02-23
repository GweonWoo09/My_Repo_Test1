using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    public List<GameObject> ListTetrominoes;
    GameObject nextSpawn;
    GameObject targetSpawn;
    bool isFirst = true;

    void Start()
    {
        Application.targetFrameRate = 60;
        ListTetrominoes = new List<GameObject>();
        NewTetromino();
    }

    public void NewTetromino()
    {
        Invoke(nameof(CreateBlocks), 0.5f);
    }

    void CreateBlocks()
    {
        if (isFirst)
        {
            isFirst = false;
            targetSpawn = Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
            ListTetrominoes.Add(targetSpawn);

            nextSpawn = Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position + new Vector3(4, 1f, 0), Quaternion.identity);
            nextSpawn.GetComponent<TetrisBlock>().enabled = false;
            nextSpawn.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else
        {
            targetSpawn = nextSpawn;
            targetSpawn.transform.position = transform.position;
            targetSpawn.transform.localScale = Vector3.one;
            targetSpawn.GetComponent<TetrisBlock>().enabled = true;
            ListTetrominoes.Add(targetSpawn);

            nextSpawn = null;
            nextSpawn = Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position + new Vector3(4, 1f, 0), Quaternion.identity);
            nextSpawn.GetComponent<TetrisBlock>().enabled = false;
            nextSpawn.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            DestoroyCheck();
        }
    }

    void DestoroyCheck()
    {
        if (ListTetrominoes.Count > 0)
        {
            for (int i = 0; i < ListTetrominoes.Count; i++)
            {
                if (ListTetrominoes[i].transform.childCount == 0)
                {
                    Destroy(ListTetrominoes[i]);
                    ListTetrominoes.RemoveAt(i);
                }
            }
        }
    }
}