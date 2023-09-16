using UnityEngine;
using System.Collections;

namespace Faker.Globals
{
	public abstract class ObjectController : MonoBehaviour
	{

		public ObjectController Init(object _info)
		{
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

		protected abstract void OnInit(object _info);
		protected abstract void OnRelease();
	}
}