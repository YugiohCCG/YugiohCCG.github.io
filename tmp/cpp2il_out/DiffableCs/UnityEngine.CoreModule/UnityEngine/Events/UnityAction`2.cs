namespace UnityEngine.Events;

public sealed class UnityAction : MulticastDelegate
{

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.GPUResidentDrawerSettings", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public UnityAction`2(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(T0 arg0, T1 arg1) { }

}

