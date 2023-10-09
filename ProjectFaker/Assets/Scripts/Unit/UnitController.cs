
using UnityEngine;

namespace Faker.Unit
{
  public class UnitController : ObjectController<UnitInfo>
  {
    [SerializeField]
    private SpriteRenderer sRenderer;

    /// <summary>
    /// 0: 병영 = Barrack
    /// 1: 출정 = Gate
    /// </summary>
    private int currentLocation;
    private Vector3 prevPosition;

    private Vector3 position {
      get => transform.position;
      set {
        transform.position = value;
      }
    }
    protected override void OnInit(UnitInfo _info)
    {
      sRenderer.sprite = ResourceStorage.Sprite.Unit[_info.Code];
      position = _info.initPos;
      currentLocation = 0;
    }

    protected override void OnRelease()
    {
    }

    private void OnMouseDown()
    {
      prevPosition = position;
    }

    private void OnMouseDrag()
    {
      position = CommonFunction.GetMousePositionOnGround(out Transform tfDetected) + (Vector3.up * 2);
      switch (tfDetected.name) {
        case "Gate":
          currentLocation = 1;
          break;
        case "Barrack":
          currentLocation = 0;
          break;
      }
    }

    private void OnMouseUp()
    {
      switch ( currentLocation) {
        case 0:
          // => Barrack
          IngameStorage.TryMoveUnitToBarrack(this);
          break;
        case 1:
          // => Gate
          if (!IngameStorage.TryMoveUnitToGate(this)) {
            position = prevPosition;
          }
          break;
      }
    }
  }
}