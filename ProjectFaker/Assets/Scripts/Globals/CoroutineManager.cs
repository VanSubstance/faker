using UnityEngine;
using System.Collections;
namespace Faker.Globals
{
	public class CoroutineManager : SingletonObject<CoroutineManager>
	{
		public void ExecuteAfterTime(System.Action actionToExec, float time = 2f)
		{
			StartCoroutine(IEnumExecAfterTime(actionToExec, time));
		}

		private IEnumerator IEnumExecAfterTime(System.Action actionToExec, float time)
		{
			yield return new WaitForSeconds(time);
			actionToExec();
		}
	}
}