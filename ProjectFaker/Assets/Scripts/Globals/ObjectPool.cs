using System.Collections.Generic;
using UnityEngine;

namespace Faker.Globals
{
	public class ObjectPool : SingletonObject<ObjectPool>
	{
		private Dictionary<string, Queue<IObjectControllable>> qPool = new Dictionary<string, Queue<IObjectControllable>>();
		private Dictionary<string, Transform> parents = new Dictionary<string, Transform>();

		public T GetObject<T>() where T : IObjectControllable
		{
			string targetPoolName = typeof(T).Name;
			if (!qPool.ContainsKey(targetPoolName)) {
				qPool[targetPoolName] = new Queue<IObjectControllable>();
				GameObject newParent = new GameObject($"{targetPoolName}Parent");
				newParent.transform.SetParent(transform);
				parents[targetPoolName] = newParent.transform;
			}
			if (qPool[targetPoolName].TryDequeue(out IObjectControllable res)) {
				return (T)res;
			} else {
				return Instantiate(ResourceStorage.Prefab.Pooling[targetPoolName].Transform(), parents[targetPoolName], true).GetComponent<T>();
			}
		}

		public void ReleaseObject<T>(T target) where T : IObjectControllable
		{
			string targetPoolName = target.GetType().Name;
			if (!qPool.ContainsKey(targetPoolName)) {
				Destroy(target.Transform());
				return;
			}
			qPool[targetPoolName].Enqueue(target);
		}
	}
}