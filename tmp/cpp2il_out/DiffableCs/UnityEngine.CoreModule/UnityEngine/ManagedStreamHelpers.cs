namespace UnityEngine;

internal static class ManagedStreamHelpers
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedStreamHelpers), Member = "ValidateLoadFromStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[RequiredByNativeCode]
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedStreamHelpers), Member = "ValidateLoadFromStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[RequiredByNativeCode]
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ManagedStreamHelpers), Member = "ValidateLoadFromStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[RequiredByNativeCode]
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[CalledBy(Type = typeof(ManagedStreamHelpers), Member = "ManagedStreamRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Stream), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManagedStreamHelpers), Member = "ManagedStreamSeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(uint), typeof(Stream), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManagedStreamHelpers), Member = "ManagedStreamLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal static void ValidateLoadFromStream(Stream stream) { }

}

