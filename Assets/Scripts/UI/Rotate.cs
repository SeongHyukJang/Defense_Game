using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
	public Vector3 rotation;
	public float speed;

	void Update () 
	{
		transform.Rotate(rotation * Time.deltaTime * speed);
	}
}
