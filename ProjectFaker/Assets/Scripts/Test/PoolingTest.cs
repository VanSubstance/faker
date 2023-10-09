using Faker.Globals;
using Faker.Unit;
using UnityEngine;

namespace Faker.Test
{
  public class PoolingTest : MonoBehaviour
  {
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space)) {
        IObjectControllable newUnit = ObjectPool.Instance.GetObject<UnitController>().Init(new UnitInfo() { Code = "Warrior", Name = "전사", initPos = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)) });
        CoroutineManager.Instance.ExecuteAfterTime(() => { newUnit.Release(); });
      }
    }
  }
}