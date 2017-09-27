using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu]
public class PlayerData : ScriptableObject {

    public float Speed;

    public float Jump;

    public int health;

    public float moveForce;
}
