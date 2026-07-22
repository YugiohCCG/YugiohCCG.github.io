namespace UnityEngine.Rendering;

public interface IDebugDisplaySettingsQuery
{

	public bool AreAnySettingsActive
	{
		 get { } //Length: 0
	}

	public bool IsLightingActive
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public bool IsPostProcessingAllowed
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public bool get_AreAnySettingsActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool get_IsLightingActive() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool get_IsPostProcessingAllowed() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool TryGetScreenClearColor(ref Color color) { }

}

