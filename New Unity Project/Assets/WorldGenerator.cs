using UnityEngine;
using System.Collections;

public class WorldGenerator : MonoBehaviour {
    public Transform[] segmentPrefabs;
    // Use this for initialization
    public void Start() {
        for (int i = 0; i < 15; ++i) {
            j = Random.Range(0, segmentPrefabs.Length);
            Instantiate(segmentPrefabs[j], new Vector3(i * 50, -10, 5), Quaternion.identity);
        }

     }

}
