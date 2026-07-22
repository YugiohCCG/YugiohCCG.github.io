namespace System.Net.NetworkInformation;

internal class Win32NetworkInterface
{
	private static Win32_FIXED_INFO fixedInfo; //Field offset: 0x0
	private static bool initialized; //Field offset: 0x58

	public static Win32_FIXED_INFO FixedInfo
	{
		[CalledBy(Type = typeof(Win32IPGlobalProperties), Member = "get_DomainName", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_FIXED_INFO_Marshal)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Win32_FIXED_INFO_Marshal))]
		[Calls(Type = typeof(Win32NetworkInterface), Member = "<get_FixedInfo>g__GetStringFromMultiByte|5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 12)]
		 get { } //Length: 1001
	}

	[CalledBy(Type = typeof(Win32NetworkInterface), Member = "get_FixedInfo", ReturnType = typeof(Win32_FIXED_INFO))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Win32NetworkInterface), Member = "MultiByteToWideChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(Byte*), typeof(int), typeof(Char*), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[CompilerGenerated]
	internal static string <get_FixedInfo>g__GetStringFromMultiByte|5_0(Byte* bytes) { }

	[CalledBy(Type = typeof(Win32IPGlobalProperties), Member = "get_DomainName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Win32_FIXED_INFO_Marshal)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Win32_FIXED_INFO_Marshal))]
	[Calls(Type = typeof(Win32NetworkInterface), Member = "<get_FixedInfo>g__GetStringFromMultiByte|5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 12)]
	public static Win32_FIXED_INFO get_FixedInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static int GetNetworkParams(IntPtr ptr, ref int size) { }

	[CalledBy(Type = typeof(Win32NetworkInterface), Member = "<get_FixedInfo>g__GetStringFromMultiByte|5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static int MultiByteToWideChar(uint CodePage, uint dwFlags, Byte* lpMultiByteStr, int cbMultiByte, Char* lpWideCharStr, int cchWideChar) { }

}

