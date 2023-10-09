using System.Collections.Generic;
using Faker.UI.PCT;
using Faker.Unit;

public static class IngameStorage
{
  public static int CurGate = 0, MaxGate = 3;

  public static List<UnitController> UnitsGate = new List<UnitController>();
  public static List<UnitController> UnitsBarrack = new List<UnitController>();

  public static bool TryMoveUnitToGate(UnitController _unit)
  {
    if (UnitsGate.Contains(_unit)) return true;
    if (MaxGate - CurGate < 1) {
      LobbyManager.Instance.TextWarn = $"출정 한도 유닛을 초과했습니다 !";
      return false;
    }
    UnitsBarrack.Remove(_unit);
    UnitsGate.Add(_unit);
    LobbyManager.Instance.CountGate++;
    return true;
  }

  public static bool TryMoveUnitToBarrack(UnitController _unit)
  {
    if (UnitsBarrack.Contains(_unit)) return true;
    UnitsBarrack.Add(_unit);
    UnitsGate.Remove(_unit);
    LobbyManager.Instance.CountGate--;
    return true;
  }
}
