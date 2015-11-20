using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class GameSettings : ScriptableObject {
	public float appear;
	public float speed;
	public List<Vector3> spawnPoints; 
		
}
