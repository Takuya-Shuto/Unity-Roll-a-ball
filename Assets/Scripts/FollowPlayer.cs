﻿using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	public Transform target;  //ターゲットへの参照
	public Vector3 offset;  //相対座標

	void start () {
		//自分自身とtargetとの相対距離を求める
		offset = GetComponent<Transform>().position - target.position;
	}

	void Update () {
		//自分の座標にtargetの座標を代入する
		GetComponent<Transform>().position = target.position + offset;
	}
}