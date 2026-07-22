namespace UnityEngine.InputSystem;

public abstract class InputProcessor
{
	internal enum CachingPolicy
	{
		CacheResult = 0,
		EvaluateOnEveryRead = 1,
	}

	internal static TypeTable s_Processors; //Field offset: 0x0

	public override CachingPolicy cachingPolicy
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected InputProcessor() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	public override CachingPolicy get_cachingPolicy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TypeHelpers), Member = "GetGenericTypeArgumentFromHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(int)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal static Type GetValueTypeFromType(Type processorType) { }

	public abstract void Process(Void* buffer, int bufferSize, InputControl control) { }

	public abstract object ProcessAsObject(object value, InputControl control) { }

}

