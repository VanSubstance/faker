using UnityEngine;

public class ResourceManager : SingletonObject<ResourceManager>
{
	private string path;
	private void Awake()
	{
		LoadPoolingObjects();
		LoadSprites();
	}

	/// <summary>
	/// 풀링용 프오브젝트 프리펩 로드
	/// </summary>
	private void LoadPoolingObjects()
	{
		path = $"Prefabs";
		foreach (GameObject obj in Resources.LoadAll<GameObject>($"{path}/PoolingObjects")) {
			IObjectControllable iobj = obj.GetComponent<IObjectControllable>();
			ResourceStorage.Prefab.Pooling[iobj.GetType().Name] = iobj;
		}
	}

	/// <summary>
	/// Loading Sprites
	/// </summary>
	private void LoadSprites()
	{
		path = $"Sprites";
		foreach (Sprite spr in Resources.LoadAll<Sprite>($"{path}/Units")) {
			ResourceStorage.Sprite.Unit[spr.name] = spr;
		}
	}
}