namespace System;

[Extension]
internal static class FixedBufferExtensions
{

	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	internal static bool FixedBufferEqualsString(ReadOnlySpan<Char> span, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static int GetFixedBufferStringLength(ReadOnlySpan<Char> span) { }

	[CalledBy(Type = typeof(FileSystem), Member = "RemoveDirectoryRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WIN32_FIND_DATA&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	internal static string GetStringFromFixedBuffer(ReadOnlySpan<Char> span) { }

}

