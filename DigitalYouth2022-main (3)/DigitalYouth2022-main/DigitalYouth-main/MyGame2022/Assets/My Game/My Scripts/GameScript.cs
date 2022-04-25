using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public EnemySpawner enemySpawner;
	public int enemiestoSpawn;

	// Use this for initialization
	protected void Start () 
	{
		enemiestoSpawn = Random.Range(1, 10);
	}
	

	// Update is called once per frame
	protected void Update () 
	{

		if(enemySpawner.transform.childCount==0 && EnemySpawner.activated)
        {
			SpawnWave();
        }
		
	}


	public void SpawnWave()
    {
		for (int i = 0; i <= enemiestoSpawn; i++)
		{
			enemySpawner.Spawn();
		}
	}



}