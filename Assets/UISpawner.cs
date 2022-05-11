using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawner : MonoBehaviour
{
	public Renderer DebugCubeRenderer;
	public GameObject Prefab;
	public Transform RefPoint;
	public GameObject Information;

	private GameObject target;

	public void OnTargetFound()
	{

		//Debug.Log("Hello: OnTargetFound Start");

		Material mat = DebugCubeRenderer.material;
		mat.color = Color.green;
		DebugCubeRenderer.material = mat;

		if (target == null)
		{
			target = Instantiate(Prefab);
			target.transform.position = RefPoint.position;
			target.transform.rotation = RefPoint.rotation;
			target.transform.localScale = RefPoint.lossyScale;
			Information.SetActive(true);
		}

		//Debug.Log("Hello: OnTargetFound Finish");

	}


	public void OnTargetLost()
	{
		//Debug.Log("Hello: OnTargetLost Start");

		Material mat = DebugCubeRenderer.material;
		mat.color = Color.red;
		DebugCubeRenderer.material = mat;
		if (target != null)
		{
			target.SetActive(false);
			target = null;
		}
		Information.SetActive(false);

		//Debug.Log("Hello: OnTargetLost Finish");
	}
}
