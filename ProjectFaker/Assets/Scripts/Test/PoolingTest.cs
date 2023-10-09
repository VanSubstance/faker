using Faker.Globals;
using Faker.Unit;
using UnityEngine;

namespace Faker.Test
{
  public class PoolingTest : MonoBehaviour
  {
    public static float var = 3f;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)) {
        IObjectControllable newUnit = ObjectPool.Instance.GetObject<UnitController>().Init(new UnitInfo() { Code = "Warrior", Name = "전사", initPos = new Vector3(Random.Range(-var, var), 1, -10f + Random.Range(-var, var)) });
        //CoroutineManager.Instance.ExecuteAfterTime(() => { newUnit.Release(); });
      }
    }
  }
}