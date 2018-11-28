using UnityEngine;
using System.Collections;

public class TerrainSpawner : MonoBehaviour
{

	public GameObject jumpTerrain;


	public float startSpawnPosition = 11.2f;
	public int spawnYPos = 0;
	

	int randomChoice;
	float lastPosition;
	GameObject cam;
	bool canSpawn = true;
	
	void Start()
	{

		lastPosition = startSpawnPosition;
		cam = GameObject.Find("Main Camera");
	}
	
	void Update()
	{

		if (cam.transform.position.x >= lastPosition - 16 && canSpawn == true)
		{
		
			canSpawn = false;
			randomChoice = Random.Range(1, 10);
			SpawnTerrain(randomChoice);
		}
	}

	void SpawnTerrain(int rand)
	{
		if (rand >= 1 && rand <= 4)
		{
			Instantiate(jumpTerrain, new Vector3(lastPosition,Random.Range(-5.0F, 5.0F)), Quaternion.Euler(0, 0, 0));
			lastPosition += Random.Range(5.0F, 15.0F);
		}

		canSpawn = true;
	}
}