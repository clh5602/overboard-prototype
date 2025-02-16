using UnityEngine;

/* Andrew Black
 * 2/16
 * TileScript handles behavior of spawning objects to tiles. Notably, this is the Debris
 * and coins.
 */
public class TileScript : MonoBehaviour
{
    public GameObject[] debris;
    public GameObject coin;
    private GameObject spawnedDebris;

    void Start()
    {
    }

    public void SpawnDebris(double debrisYMod)
    {
        // check if null
        if (debris.Length > 0 && spawnedDebris == null) 
        {
            int index = Random.Range(0, debris.Length); 
            spawnedDebris = Instantiate(debris[index], new Vector3(transform.position.x, transform.position.y + transform.localScale.y / 2 + (float)debrisYMod,
                transform.position.z), Quaternion.Euler(90, 90, 90));
            spawnedDebris.GetComponent<DebrisScript>().FrameSwitchIncrement(debrisYMod * 1000);
        }
    }

    public void SpawnCoin()
    {
        Instantiate(coin, new Vector3(transform.position.x, transform.position.y + transform.localScale.y * 2.1f, transform.localScale.z), Quaternion.identity);
    }

    public void DespawnDebris()
    {
        // safety net if function is incorrectly called
        if (spawnedDebris != null) 
        {
            Destroy(spawnedDebris);
            spawnedDebris = null; 
        }
    }
}
