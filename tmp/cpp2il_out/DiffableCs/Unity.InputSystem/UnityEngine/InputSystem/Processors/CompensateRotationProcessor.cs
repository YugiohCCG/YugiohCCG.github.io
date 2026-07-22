namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(False)]
internal class CompensateRotationProcessor : InputProcessor<Quaternion>
{

	public virtual CachingPolicy cachingPolicy
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CompensateRotationProcessor() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual CachingPolicy get_cachingPolicy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Quaternion Process(Quaternion value, InputControl control) { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

