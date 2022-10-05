using SgLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObjects : MonoBehaviour
{
    public GameObject firstPrefab,zeroPrefab,dadecaedr,fiveangle,piramid,tetraeder, cylindercoin;

    private float spawnRate = 3f;
    public ScoreManager scoreManager;

    float nextSpawn = 0f;
    List<GameObject> spgmob = new List<GameObject>();
    int howManyToSpawn;
    float randomPos,posSpnPart;

    // Update is called once per frame
    void Update()
    {

        if(Time.time>nextSpawn)
        {
            howManyToSpawn = Random.Range(0, 12);
            randomPos = Random.Range(-0.40f, 0.40f);
            switch(howManyToSpawn)
            { 
                
                case 0:
                    spgmob.Add(Instantiate(firstPrefab, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 1:
                    spgmob.Add(Instantiate(dadecaedr, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 2:
                    spgmob.Add(Instantiate(fiveangle, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 3:
                    spgmob.Add(Instantiate(piramid, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 4:
                    spgmob.Add(Instantiate(tetraeder, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 5:
                    spgmob.Add(Instantiate(tetraeder, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 6:
                    spgmob.Add(Instantiate(zeroPrefab, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 7:
                    spgmob.Add(Instantiate(firstPrefab, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 8:
                    spgmob.Add(Instantiate(dadecaedr, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 9:
                    spgmob.Add(Instantiate(fiveangle, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 10:
                    spgmob.Add(Instantiate(piramid, new Vector3(randomPos, (float)8.5, 0), Quaternion.identity));
                    break;
                case 11:
                     spgmob.Add(Instantiate(cylindercoin, new Vector3(0, (float)8.5, 0), Quaternion.identity));
                    break;
                default:
                    Debug.Log("OMG!!!");
                    break;
                
            }
          
            nextSpawn = Time.time + spawnRate;

        } 
    }


    

    public void SpanPartc(ParticleSystem particleSystem,Collision collision)
    {
        float position = posSpnPart;
        
        Instantiate(particleSystem, collision.contacts[0].point, Quaternion.identity);
    }

    public void SpanPartc1(ParticleSystem particleSystem, Collision collision)
    {
        

        Instantiate(particleSystem, transform.TransformPoint(0, 1.2f, 0), Quaternion.identity);
    }


    public void DestroyAll()
    {
        for(int i = 0;i<spgmob.Count;i++)
        {
            Destroy(spgmob[i]);
        }
        spgmob.Clear();
    }
}
