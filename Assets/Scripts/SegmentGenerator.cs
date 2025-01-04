using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{
   public GameObject[] segmentPrefabs;  // Drag Segment01, Segment02, Segment03 to this array
    public Transform playerTransform;    // Drag the player transform here
    private List<GameObject> activeSegments = new List<GameObject>();

     private float spawnZ = 0.0f;           // Z position to spawn next segment
    private float segmentLength = 88.0f;   // Distance between each segment
    private int initialSegments = 2;       // Start with 2 segments
    private int segmentsToSpawn = 2;       // Spawn 2 segments on trigger
    private int safeZone = 200;            // Safe zone for despawning

    void Update()
    {
        // Ensure segments stay ahead of the player if needed
        while (playerTransform.position.z + (initialSegments - 1) * segmentLength > spawnZ)
        {
            SpawnSegment();
        }
    }

    void SpawnSegment()
{
    GameObject segment = Instantiate(segmentPrefabs[Random.Range(0, segmentPrefabs.Length)], 
                                     Vector3.forward * spawnZ, 
                                     Quaternion.identity);

    // Assign AudioSource to each coin individually
    CollectCoins[] coins = segment.GetComponentsInChildren<CollectCoins>();


    activeSegments.Add(segment);
    spawnZ += segmentLength;
}



    void DeleteSegment()
    {
        // Destroy the oldest 2 segments to keep segments in control
        for (int i = 0; i < segmentsToSpawn; i++)
        {
            if (activeSegments.Count > initialSegments)
            {
                Destroy(activeSegments[0]);
                activeSegments.RemoveAt(0);
            }
        }
    }

    // Trigger-based segment spawning
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Demo_Asphalt (22)")
        {
            // Spawn 2 segments on trigger
            for (int i = 0; i < segmentsToSpawn; i++)
            {
                SpawnSegment();
            }
            // Despawn the oldest 2 segments
            DeleteSegment();
        }
    }

}
