using Faker.Globals;
using UnityEngine;

namespace Faker.Unit
{
  public class UnitController : ObjectController<UnitInfo>
  {
    [SerializeField]
    private SpriteRenderer sRenderer;

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
    }

    protected override void OnRelease()
    {
    }

    private void OnMouseDown()
    {
      Debug.Log("Click Start");
    }

    private void OnMouseDrag()
    {
      position = CommonFunction.GetMousePositionOnGround() + (Vector3.up * 2);
    }

    private void OnMouseUp()
    {
      Debug.Log($"Click End");
    }
  }
}