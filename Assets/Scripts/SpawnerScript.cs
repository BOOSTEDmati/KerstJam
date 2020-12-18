using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private GameObject Spawn;
    [SerializeField]
    private GameObject Tree;

    private float SpawnTime = 2.5f;

    void Start()
    {

        StartCoroutine(spawn());
    }


    void A()
    {
        Spawn = Instantiate(Tree, transform.position, Quaternion.identity) as GameObject;
        ScoreScript.scoreValue += 1;
    }

    IEnumerator spawn() 
{
    while(true)
    {
        yield return new WaitForSeconds(Random.Range(1f, SpawnTime));

        A();
    }
}
}
