namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(False)]
internal class CompensateDirectionProcessor : InputProcessor<Vector3>
{

	public virtual CachingPolicy cachingPolicy
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CompensateDirectionProcessor() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual CachingPolicy get_cachingPolicy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "get_settings", ReturnType = typeof(InputSettings))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[CallerCount(Count = 0)]
	public virtual string ToString() { }

}

