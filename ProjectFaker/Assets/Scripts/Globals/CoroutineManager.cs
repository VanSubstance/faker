using UnityEngine;
using System.Collections;

public class CoroutineManager : SingletonObject<CoroutineManager>
{
	public Coroutine ExecuteAfterTime(System.Action actionToExec, float time = 5f)
	{
		return StartCoroutine(IEnumExecAfterTime(actionToExec, time));
	}

	private IEnumerator IEnumExecAfterTime(System.Action actionToExec, float time)
	{
		yield return new WaitForSeconds(time);
		actionToExec();
	}
}