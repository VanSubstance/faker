using UnityEngine;
using System.Collections;

namespace Faker.Globals
{
  public interface IObjectControllable
  {
    public Transform Transform();
    public void Release();
  }
}