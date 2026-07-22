namespace System.IO;

[Extension]
internal static class MonoLinqHelper
{

	[CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFiles", ReturnType = typeof(FileInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(FileInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", ReturnType = typeof(FileSystemInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetFileSystemInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(FileSystemInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetDirectories", ReturnType = typeof(DirectoryInfo[]))]
	[CalledBy(Type = typeof(DirectoryInfo), Member = "GetDirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(EnumerationOptions)}, ReturnType = typeof(DirectoryInfo[]))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(EnumerableHelpers), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static T[] ToArray(IEnumerable<T> source) { }

}

