using System;
using UnityEngine;


public class TileBoardPopulator : MonoBehaviour
{

    public GameObject tile;
    public int amount;

    private int gridDividerInt;
    private GameObject[] tiles;

    void Start()
    {
        gridDividerInt = DetermineAmountSqRt();
        CreateBoard();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int DetermineAmountSqRt()
    {
        return (int)(Math.Sqrt(amount));
    }

    private void CreateBoard()
    {
        Debug.Log("createboard");
        tiles = new GameObject[this.amount];

        int xOffset = 0;
        int zOffset = 0;

        for(int i = 1; i < amount+1; i++)
        {
            tiles[i-1] = Instantiate(tile, new Vector3(xOffset, 0, zOffset), Quaternion.identity);
            tiles[i-1].transform.SetParent(this.transform);

            if((i % gridDividerInt) == 0)
            {
                xOffset = 0;
                zOffset += (int)tile.GetComponent<Renderer>().bounds.size.z;
            }
            else
            {
                xOffset += (int)tile.GetComponent<Renderer>().bounds.size.x;
            }
        }
    }
}
