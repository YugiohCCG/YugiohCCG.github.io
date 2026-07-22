namespace UnityEngine.Rendering;

public class ConstantBuffer : ConstantBufferBase
{
	private HashSet<Int32> m_GlobalBindings; //Field offset: 0x0
	private CBType[] m_Data; //Field offset: 0x0
	private ComputeBuffer m_GPUConstantBuffer; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ConstantBuffer`1() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void PushGlobal(CommandBuffer cmd, in CBType data, int shaderId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void PushGlobal(in CBType data, int shaderId) { }

	[CalledBy(Type = typeof(ConstantBufferSingleton`1), Member = "Release", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HashSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.HashSet`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SafeRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Release() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Set(CommandBuffer cmd, ComputeShader cs, int shaderId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Set(ComputeShader cs, int shaderId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Set(Material mat, int shaderId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void Set(MaterialPropertyBlock mpb, int shaderId) { }

	[CalledBy(Type = typeof(ConstantBuffer), Member = "PushGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"CBType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetGlobal(CommandBuffer cmd, int shaderId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "get_stride", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetGlobal(int shaderId) { }

	[CalledBy(Type = typeof(ConstantBuffer), Member = "PushGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"CBType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetBufferData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer), typeof(Array)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void UpdateData(CommandBuffer cmd, in CBType data) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public void UpdateData(in CBType data) { }

}

