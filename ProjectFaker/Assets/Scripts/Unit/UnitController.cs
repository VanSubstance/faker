using Faker.Globals;
using UnityEngine;

namespace Faker.Unit
{
  public class UnitController : ObjectController<UnitInfo>
  {
    [SerializeField]
    private SpriteRenderer sRenderer;
    protected override void OnInit(UnitInfo _info)
    {
      sRenderer.sprite = ResourceStorage.Sprite.Unit[_info.Code];
    }

    protected override void OnRelease()
    {
    }
  }
}