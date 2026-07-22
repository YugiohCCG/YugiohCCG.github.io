namespace UnityEngine.Rendering;

internal class ConstantBufferSingleton : ConstantBuffer<CBType>
{
	private static ConstantBufferSingleton<CBType> s_Instance; //Field offset: 0x0

	internal static ConstantBufferSingleton<CBType> instance
	{
		[CalledBy(Type = typeof(ConstantBuffer), Member = "PushGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"CBType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ConstantBuffer), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstantBufferBase)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 18)]
		[DeduplicatedMethod]
		internal get { } //Length: 770
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		internal set { } //Length: 149
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public ConstantBufferSingleton`1() { }

	[CalledBy(Type = typeof(ConstantBuffer), Member = "PushGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"CBType"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "CBType&", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(ComputeBufferType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConstantBuffer), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstantBufferBase)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	internal static ConstantBufferSingleton<CBType> get_instance() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstantBuffer`1), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public virtual void Release() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal static void set_instance(ConstantBufferSingleton<CBType> value) { }

}

