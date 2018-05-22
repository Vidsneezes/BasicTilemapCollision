using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour {

    public float Yspeed;
    public float Xspeed;

    public float halfTileSize;

    public Tilemap tilemap;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPosition = transform.position;
        newPosition.x += Xspeed * Time.deltaTime;
        Vector3Int cellPos = Vector3Int.FloorToInt(newPosition + Vector3.right * halfTileSize);
        if (tilemap.HasTile(cellPos))
        {
            newPosition.x = transform.position.x;
        }

        newPosition.y += Yspeed * Time.deltaTime;
        cellPos = Vector3Int.FloorToInt(newPosition + Vector3.up * halfTileSize);
        if (tilemap.HasTile(cellPos))
        {
            newPosition.y = transform.position.y;
        }


        transform.position = newPosition;
        
	}
}
