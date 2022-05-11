using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectOnEnable : MonoBehaviour
{
	public GameObject Prefab;
	public Transform SpawnPoint;

	private GameObject target;

	private void OnEnable()
	{
		if (target == null)
		{
			target = Instantiate(Prefab);
		}

		target.transform.position = SpawnPoint.position;
		target.transform.rotation = SpawnPoint.rotation;
		target.transform.localScale = SpawnPoint.lossyScale;
	}
}
