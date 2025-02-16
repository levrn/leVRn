﻿using UnityEngine;
using System.Collections;

public class MenuSpawn : MonoBehaviour
{
	public Transform leftHandMenu;
	public Transform rightHandMenu;
	public Transform leftPalm;
	public Transform rightPalm;
	public Transform mainCamera;
	public Transform dataTracker;
	Vector3 trackedTransform;
	int trackedData;
	// Use this for initialization
	void Start()
	{
		leftHandMenu.gameObject.SetActive(false);
		rightHandMenu.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		trackedTransform = dataTracker.localPosition;
		trackedData = (int)trackedTransform.x;
		if (trackedData == 1)
		{
			SpawnLeftHandMenu();
		}
		else if (trackedData == 2)
		{
			SpawnRightHandMenu();
		}
		else
		{
			rightHandMenu.gameObject.SetActive(false);
			leftHandMenu.gameObject.SetActive(false);
		}
	}

	void SpawnLeftHandMenu()
	{
		leftHandMenu.gameObject.SetActive(true);
		leftHandMenu.position = leftPalm.position - (leftPalm.right * 0.05f) - (leftHandMenu.forward * 0.15f) + (leftHandMenu.up * 0.1f);
		leftHandMenu.LookAt(mainCamera);
	}

	void SpawnRightHandMenu()
	{
		rightHandMenu.gameObject.SetActive(true);
		rightHandMenu.position = rightPalm.position + (rightPalm.right * 0.05f) - (rightHandMenu.forward * 0.15f) + (rightHandMenu.up * 0.1f);
		rightHandMenu.LookAt(mainCamera);
	}
}
