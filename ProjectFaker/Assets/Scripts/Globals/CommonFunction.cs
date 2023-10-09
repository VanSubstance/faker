using System;
using UnityEngine;

namespace Faker.Globals
{
  public static class CommonFunction
  {

    public static Vector3 GetMousePositionOnGround()
    {
      if (Physics.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Constant.VectorFromCameraToWorld, out RaycastHit hit, 100, Constant.LayerMask.Ground)) {
        return hit.point;
      }
      return new Vector3(0, 1000, 0);
    }
  }
}