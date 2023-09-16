using UnityEngine;

namespace Faker.Globals
{
	public class ResourceManager : SingletonObject<ResourceManager>
	{
		private string path;
		private void Awake()
		{
			LoadPoolingObjects();
		}

		/// <summary>
		/// 풀링용 프오브젝트 프리펩 로드
		/// </summary>
		private void LoadPoolingObjects()
		{
			path = $"Prefabs";
			foreach (ObjectController obj in Resources.LoadAll<ObjectController>($"{path}/PoolingObjects")) {
				ResourceStorage.Prefab.Pooling[obj.GetType().Name] = obj;
			}
		}
	}
}
