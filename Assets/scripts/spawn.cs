using NUnit.Framework;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
public class spawn : MonoBehaviour
{
    public Camera cam;
    public GameObject HitPoint;
    public GameObject[] objectPrefabs;
    public int count = 10;
    public float distance = 10f;

    public PlayerCon PlayerCon;

    private List<GameObject> spawnedObjects = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        

        if (cam ==null)
        {
            cam = Camera.main;
        }
        SpawnObjectInview();
    }

    // Update is called once per frame
    void Update()
    {
        spawnedObjects.RemoveAll(obj => obj == null);

        if (spawnedObjects.Count < count)
        {
            SpawnObjectInview();
        }


    }

    void SpawnObjectInview()
    {
        if (objectPrefabs.Length == 0)
        {
            Debug.LogWarning("objectPrefabs ”z—ñ‚ª‹ó");
            return;
        }
        int needed = count - spawnedObjects.Count;

        for (int i = 0; i < needed; i++)
        {
            Vector3 randomViewportPos = new Vector3(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                distance
            );

            Vector3 worldPos = cam.ViewportToWorldPoint(randomViewportPos);

            GameObject selectedPrefab = objectPrefabs[Random.Range(0, objectPrefabs.Length)];

            GameObject obj = Instantiate(selectedPrefab, worldPos, Quaternion.identity);
            spawnedObjects.Add(obj);

        }
    }
}
