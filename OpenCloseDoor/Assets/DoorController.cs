using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	private Animator anim;
	
	void Start ()
	{
		anim = this.transform.parent.GetComponent<Animator>();
	}
	
	private void OnTriggerEnter(Collider other)
	{
		anim.SetBool("isOpening", true);
	}

	private void OnTriggerExit(Collider other)
	{
		anim.SetBool("isOpening", false);
	}
}
