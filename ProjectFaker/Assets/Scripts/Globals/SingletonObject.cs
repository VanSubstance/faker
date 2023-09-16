using UnityEngine;

namespace Faker.Globals
{
  public class SingletonObject<T> : MonoBehaviour where T : MonoBehaviour
  {
    private static T instance;
    public static T Instance
    {
      get
      {
        if (instance == null)
        {
          instance = FindObjectOfType<T>();
          if (instance == null)
          {
            // 메모리 상에도 없으면 생성
            GameObject newSingleton = new GameObject();
            newSingleton.name = typeof(T).Name;
            instance = newSingleton.AddComponent<T>();
          }
        }
        return instance;
      }
    }
  }
}
