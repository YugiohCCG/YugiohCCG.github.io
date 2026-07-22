namespace UnityEngine.Rendering;

public interface IDebugDisplaySettings
{

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public IDebugDisplaySettingsData Add(IDebugDisplaySettingsData newData) { }

	public void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }

	public void Reset() { }

}

