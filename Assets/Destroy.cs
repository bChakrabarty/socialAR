using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	public GameObject Target;
	public void DestroyTarget()
	{
		Destroy(Target);
	}
}
