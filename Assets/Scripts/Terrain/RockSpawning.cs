using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawning : MonoBehaviour
{
    public GameObject rock;
    public float radiusSpawn = 10;
    public int numOfBasicRock = 10;
    public float heightAboveGround = 2.0f;
    public LayerMask groundLayer;
    Transform tr;
    RaycastHit hit;

    void Awake()
    {
        tr = transform;
    }

    void Start()
    {
        for (int i = 0; i < numOfBasicRock; i++)
        {
            Vector2 randomCircle = Random.insideUnitCircle * radiusSpawn;
            Vector3 v3rc = new Vector3(tr.position.x + randomCircle.x, 100, tr.position.z + randomCircle.y);
            if (Physics.Raycast(v3rc, Vector3.down, out hit, 150, groundLayer))
            {
                GameObject rockRay = Instantiate(rock);
                rockRay.transform.SetPositionAndRotation(new Vector3(v3rc.x, hit.point.y + heightAboveGround, v3rc.z), tr.rotation);
                rockRay.transform.parent = tr;
            }
        }
    }

}
