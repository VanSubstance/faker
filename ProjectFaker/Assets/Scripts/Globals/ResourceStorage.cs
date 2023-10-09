using System.Collections.Generic;

public static class ResourceStorage
{
	public static class Prefab
	{
		public static Dictionary<string, IObjectControllable> Pooling = new Dictionary<string, IObjectControllable>();
	}

	public static class Sprite
  {
		public static Dictionary<string, UnityEngine.Sprite> Unit = new Dictionary<string, UnityEngine.Sprite>();
  }
}
