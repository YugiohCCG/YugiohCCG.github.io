namespace UnityEngine;

internal struct TypeDispatchData : IDisposable
{
	public Object[] changed; //Field offset: 0x0
	public NativeArray<Int32> changedID; //Field offset: 0x8
	public NativeArray<Int32> destroyedID; //Field offset: 0x18

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentDrawer", Member = "PostPostLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void Dispose() { }

}

