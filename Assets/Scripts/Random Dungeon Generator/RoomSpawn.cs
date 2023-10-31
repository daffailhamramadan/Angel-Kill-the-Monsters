using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawn : MonoBehaviour
{
    private RoomTemplates roomTemplates;

    private int randomIndex;

    private Transform parent;

    public enum DoorDirection
    {
        Bottom,

        Top,

        Left,

        Right,

        Zero
    }

    public DoorDirection doorDirection;

    public bool spawned;
  
    private void Awake()
    {
        roomTemplates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }

    private void Start()
    {
        Invoke("Spawn", 0.1f);

        parent = GameObject.Find("Rooms").GetComponent<Transform>();

        Destroy(this.gameObject, 10f);
    }

    private void Spawn()
    {
        if(spawned == false)
        {
            if (doorDirection == DoorDirection.Bottom)
            {
                randomIndex = Random.Range(0, roomTemplates.roomBottom.Length);

                Instantiate(roomTemplates.roomBottom[randomIndex], transform.position, Quaternion.identity, parent);
            }
            else if (doorDirection == DoorDirection.Top)
            {
                randomIndex = Random.Range(0, roomTemplates.roomTop.Length);

                Instantiate(roomTemplates.roomTop[randomIndex], transform.position, Quaternion.identity, parent);
            }
            else if (doorDirection == DoorDirection.Left)
            {
                randomIndex = Random.Range(0, roomTemplates.roomLeft.Length);

                Instantiate(roomTemplates.roomLeft[randomIndex], transform.position, Quaternion.identity, parent);
            }

            else if (doorDirection == DoorDirection.Right)
            {
                randomIndex = Random.Range(0, roomTemplates.roomRight.Length);

                Instantiate(roomTemplates.roomRight[randomIndex], transform.position, Quaternion.identity, parent);
            }

            spawned = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpawnPoints"))
        {
            if(collision.GetComponent<RoomSpawn>().spawned == false && spawned == false)
            {
                Instantiate(roomTemplates.closedRoom, transform.position, Quaternion.identity);
            }

            spawned = true;
        }
    }
}
