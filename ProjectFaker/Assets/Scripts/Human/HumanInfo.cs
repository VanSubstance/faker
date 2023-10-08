using System;
using Faker.Globals;
using UnityEngine;

namespace Faker.Human
{
	public class HumanInfo
	{
		private string name;
		public string Name {
			get => name;
			set {
				name = value;
			}
		}
		public Vector3 initPos;

		public static explicit operator HumanInfo(UnityEngine.Object v)
		{
			throw new NotImplementedException();
		}
	}
}