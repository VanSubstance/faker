using UnityEngine;
using System.Collections;


namespace Faker.UI
{
	[RequireComponent(typeof(ShardManager))]
	public class UIManager : SingletonObject<UIManager>
	{
		private ShardManager shardManager;
		public ShardManager Shard {
			get {
				return shardManager;
			}
		}

		private void Awake()
		{
			shardManager = GetComponent<ShardManager>();
		}
	}
}
