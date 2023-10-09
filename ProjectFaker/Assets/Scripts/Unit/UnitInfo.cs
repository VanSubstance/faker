using System;
using Faker.Globals;
using UnityEngine;

namespace Faker.Unit
{
  public class UnitInfo
  {
    private string code;
    private string name;

    public string Name {
      get => name;
      set {
        name = value;
      }
    }
    public string Code {
      get => code;
      set {
        code = value;
      }
    }

    public Vector3 initPos;
  }
}