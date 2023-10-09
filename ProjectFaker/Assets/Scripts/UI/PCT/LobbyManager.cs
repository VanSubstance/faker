using Faker.UI.Button;
using Faker.Unit;
using TMPro;
using UnityEngine;

namespace Faker.UI.PCT
{
  public class LobbyManager : SingletonObject<LobbyManager>
  {
    [SerializeField]
    private TextMeshProUGUI uguiCountGate, uguiWarn;
    [SerializeField]
    private ButtonController buttonRecruit;

    private Coroutine crWarn;
    public static float var = 3f;

    public int CountGate {
      get => IngameStorage.CurGate;
      set {
        IngameStorage.CurGate = value;
        uguiCountGate.text = $"출정 유닛 수 : {IngameStorage.CurGate} / {IngameStorage.MaxGate}";
      }
    }

    private string textWarn = string.Empty;
    public string TextWarn {
      get => textWarn;
      set {
        textWarn = value;
        uguiWarn.text = value;
        if (crWarn != null) CoroutineManager.Instance.StopCoroutine(crWarn);
        crWarn = CoroutineManager.Instance.ExecuteAfterTime(() => {
          textWarn = string.Empty;
          uguiWarn.text = textWarn;
        }, 1.2f);
      }
    }

    private void Start()
    {
      buttonRecruit.AddClickEvent(() => {
        IObjectControllable newUnit = ObjectPool.Instance.GetObject<UnitController>().Init(new UnitInfo() { Code = "Warrior", Name = "전사", initPos = new Vector3(Random.Range(-var, var), 1, -10f + Random.Range(-var, var)) });
        IngameStorage.UnitsBarrack.Add(newUnit as UnitController);
      });
      CountGate += 0;
      TextWarn = string.Empty;
    }
  }
}