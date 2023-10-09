using UnityEngine;
using System.Collections;

namespace Faker.Globals
{
	public abstract class ObjectController<T> : MonoBehaviour, IObjectControllable
	{
		private T info;
		public T Info {
			get {
				return info;
			}
		}
		public IObjectControllable Init(T _info)
		{
			info = _info;
			gameObject.SetActive(true);
			OnInit(_info);
			return this;
		}

		public void Release()
		{
			gameObject.SetActive(false);
			ObjectPool.Instance.ReleaseObject(this);
			OnRelease();
		}

		public Transform Transform()
		{
			return transform;
		}

		protected abstract void OnInit(T _info);
		protected abstract void OnRelease();
	}
}