namespace UnityEngine;

internal static class SubsystemDescriptorBindings
{

	[CalledBy(Type = typeof(IntegratedSubsystemDescriptor), Member = "get_id", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	public static string GetId(IntPtr descriptorPtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetId_Injected(IntPtr descriptorPtr, out ManagedSpanWrapper ret) { }

}

