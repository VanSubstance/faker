using System.Collections.Generic;
using UnityEngine;

public static class Constant
{
  public static Vector3 VectorFromCameraToWorld = new Vector3(0, -Mathf.Sqrt(3), 1);

  public static class LayerMask
  {
    public static UnityEngine.LayerMask Ground = 1 << 6;
    public static UnityEngine.LayerMask Unit = 1 << 7;
    public static UnityEngine.LayerMask Block = 1 << 8;
  }
}
