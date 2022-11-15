using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemyPrefab;

	public Transform[] spawnPositions;

	public float timeToSpawn = 5f;

	private float timeSinceLastSpawn;

	// Start is called before the first frame update

	// Update is called once per frame
	private void Update()
	{
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn > timeToSpawn)
		{
			timeSinceLastSpawn = 0;
			int rand = Random.Range(0, spawnPositions.Length);
			Transform randonPos = spawnPositions[rand];
			Instantiate(enemyPrefab, randonPos.position, Quaternion.identity);
		}
	}
}