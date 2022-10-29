using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject diamond;
    public GameObject parent;
    Vector3 lastPos;
    float size;
    private void Awake()
    {
        
    }

    private void Start()
    {
        lastPos = transform.position;
        size = platform.transform.localScale.x;
        for (int i = 0; i < 25; i++)
            SpawnPlatforms();
    }
    private void Update()
    {
        if (GameManager.instance.gameOver)
            CancelInvoke("SpawnPlatforms");
    }
    public void StartSpawnPlatform()
    {
        InvokeRepeating("SpawnPlatforms", 0f, .2f);
    }
    void SpawnPlatforms()
    {
        int rand = Random.Range(0, 6);
        if (rand < 3)
            SpawnX();
        else SpawnZ();
    }
    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        lastPos = pos;
        GameObject parentGO = Instantiate(parent,pos,Quaternion.identity);
        Instantiate(platform, pos, Quaternion.identity,parentGO.transform);

        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1f, pos.z), diamond.transform.rotation, parentGO.transform);
        }
    }
    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        lastPos = pos;
        GameObject parentGO = Instantiate(parent, pos, Quaternion.identity);
        Instantiate(platform, pos, Quaternion.identity, parentGO.transform);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1f, pos.z), diamond.transform.rotation, parentGO.transform);
        }
    }
}
