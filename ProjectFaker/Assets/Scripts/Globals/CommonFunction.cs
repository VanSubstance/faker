using System;
using UnityEngine;

public static class CommonFunction
{

  public static Vector3 GetMousePositionOnGround(out Transform tfDetected)
  {
    if (Physics.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Constant.VectorFromCameraToWorld, out RaycastHit hit, 100, Constant.LayerMask.Ground)) {
      tfDetected = hit.transform;
      return hit.point;
    }
    tfDetected = null;
    return new Vector3(0, 1000, 0);
  }
}