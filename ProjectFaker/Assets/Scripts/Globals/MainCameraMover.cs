﻿using Faker.UI;
using Faker.UI.PCT;
using UnityEngine;

public class MainCameraMover : MonoBehaviour
{
	private Vector3? posDragStart, posDragIng;
	private Vector3 dirMove;

	private void Update()
	{
		switch (PCTManager.Instance.CurrentContentActive) {
			case PCTEnum.Inventory:
			case PCTEnum.Shop:
				return;
		}

		//ExecuteDragCamera();
	}

	private void ExecuteDragCamera()
	{
		if (Input.GetMouseButtonDown(0)) {
			posDragStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			UIManager.Instance.Shard.TouchStart((Vector3)posDragStart);
		}

		if (posDragStart != null) {
			if (Input.GetMouseButton(0)) {
				posDragIng = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				UIManager.Instance.Shard.TouchIng((Vector3)posDragIng);
				Move();
			} else {
				UIManager.Instance.Shard.TouchEnd();
				posDragStart = null;
				posDragIng = null;
			}
		}
	}

	private void Move()
	{
		dirMove = UIManager.Instance.Shard.TouchGetDirection();
		dirMove.y = 0;
		float curLeng;
		if ((curLeng = dirMove.magnitude) > 5f) {
			dirMove *= 5f / curLeng;
		}
		transform.Translate(dirMove * 3 * Time.deltaTime);
	}
}