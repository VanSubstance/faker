using UnityEngine;
using System.Collections;

public interface IObjectControllable
{
  public Transform Transform();
  public void Release();
}