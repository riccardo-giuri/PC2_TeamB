using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    //1 = bottom door
    //2 = top door
    //3 = left door
    //4 = right door
    public int Direction;

    private RoomDatabase RoomDatabase;
    private int rand;
    private bool Spawned = false;

    void Start()
    {
        RoomDatabase = FindObjectOfType<RoomDatabase>();
        Invoke("Spawn", 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if(Spawned == false)
        {
            if (Direction == 1)
            {
                rand = Random.Range(0, RoomDatabase.BottomRooms.Length);
                Instantiate(RoomDatabase.BottomRooms[rand], transform.position, Quaternion.identity);
            }
            else if (Direction == 2)
            {
                rand = Random.Range(0, RoomDatabase.TopRooms.Length);
                Instantiate(RoomDatabase.TopRooms[rand], transform.position, Quaternion.identity);
            }
            else if (Direction == 3)
            {
                rand = Random.Range(0, RoomDatabase.LeftRooms.Length);
                Instantiate(RoomDatabase.LeftRooms[rand], transform.position, Quaternion.identity);
            }
            else if (Direction == 4)
            {
                rand = Random.Range(0, RoomDatabase.RightRooms.Length);
                Instantiate(RoomDatabase.RightRooms[rand], transform.position, Quaternion.identity);
            }

            Spawned = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            if(other.GetComponent<RoomSpawner>() != null)
            {
                if (other.GetComponent<RoomSpawner>().Spawned == false && Spawned == false)
                {
                    RoomDatabase = FindObjectOfType<RoomDatabase>();
                    Instantiate(RoomDatabase.CloserRooms[Direction - 1], transform.position, Quaternion.identity);
                    Destroy(other.gameObject);
                    Destroy(this.gameObject);
                }
                Spawned = true;
            }
        }
    }

}
