using UnityEngine;


public class CirclePressurePlateController : MonoBehaviour
{
	public bool isPressed;
	public string collisionTag;
	public GameObject target;
	private Transform tr;

	// Use this for initialization
	private void Start()
	{
		tr = GetComponent<Transform>();
	}


	public void targeting(GameObject obj)
	{
		target = obj;
	}	

	private void OnTriggerEnter(Collider _other)
	{
		if (_other.tag == collisionTag)
		{
			Press();
		}
	}

	private void OnTriggerExit(Collider _other)
	{
		if (_other.tag == collisionTag)
		{
			UnPress();
		}
	}

	private void Press()
	{
		isPressed = true;



	}

	private void UnPress()
	{
		isPressed = false;

	}

	// Update is called once per frame
	private void Update()
	{
	}
}