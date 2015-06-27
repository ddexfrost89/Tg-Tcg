using UnityEngine;
using System.Collections;

public class UserControl : MonoBehaviour {
	
	private Vector3 MP;//  mouse position
	private Vector3 SMP;// screen mouse position
	private Vector3 Scale;
	private Vector3 teststep = new Vector3(1, 0, 0);

	// Use this for initialization
	void Start () {
	
	}

	private bool IsMouseIn(){
		SMP = Camera.main.ScreenToWorldPoint(MP);
		Scale = transform.lossyScale;
		if (SMP.x < transform.position.x + Scale.x/2)
			if (SMP.x > transform.position.x - Scale.x/2)
				if (SMP.y > transform.position.y - Scale.y/2)
					if (SMP.y < transform.position.y + Scale.y/2)
						return true;
		return false;
	}

	private bool IsTargeted(){
		MP = Input.mousePosition;
		return Input.GetKey (KeyCode.Mouse0) && IsMouseIn();
	}

	// Update is called once per frame
	void Update () {
		if (IsTargeted())
			transform.position = transform.position + teststep;
	}
}
