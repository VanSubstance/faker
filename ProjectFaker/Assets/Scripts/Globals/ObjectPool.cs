using System.Collections.Generic;
using UnityEngine;

namespace Faker.Globals
{
	public class ObjectPool : SingletonObject<ObjectPool>
	{
		private Dictionary<string, Queue<ObjectController>> qPool = new Dictionary<string, Queue<ObjectController>>();
		private Dictionary<string, Transform> parents = new Dictionary<string, Transform>();

		public T GetObject<T>() where T : ObjectController
		{
			string targetPoolName = typeof(T).Name;
			if (!qPool.ContainsKey(targetPoolName)) {
				qPool[targetPoolName] = new Queue<ObjectController>();
				GameObject newParent = new GameObject($"{targetPoolName}Parent");
				newParent.transform.SetParent(transform);
				parents[targetPoolName] = newParent.transform;
			}
			if (qPool[targetPoolName].TryDequeue(out ObjectController res)) {
				return res.GetComponent<T>();
			} else {
				return Instantiate(ResourceStorage.Prefab.Pooling[targetPoolName], parents[targetPoolName], true).GetComponent<T>();
			}
		}

		public void ReleaseObject<T>(T target) where T : ObjectController
		{
			string targetPoolName = target.GetType().Name;
			if (!qPool.ContainsKey(targetPoolName)) {
				Destroy(target);
				return;
			}
			qPool[targetPoolName].Enqueue(target);
		}
	}

}