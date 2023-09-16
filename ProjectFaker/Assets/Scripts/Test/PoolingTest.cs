using Faker.Globals;
using Faker.Human;
using UnityEngine;

namespace Faker.Test
{
	public class PoolingTest : MonoBehaviour
	{
		// Update is called once per frame
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space)) {
				HumanController newHuman = ObjectPool.Instance.GetObject<HumanController>().Init(new HumanInfo() { Name = "Steve", initPos = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)) }) as HumanController;
				CoroutineManager.Instance.ExecuteAfterTime(() => { newHuman.Release(); });
			}
		}
	}
}