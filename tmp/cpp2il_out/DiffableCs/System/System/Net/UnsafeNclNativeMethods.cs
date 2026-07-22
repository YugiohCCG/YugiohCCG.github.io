namespace System.Net;

internal static class UnsafeNclNativeMethods
{
	public static class HttpApi
	{
		public static class HTTP_REQUEST_HEADER_ID
		{
			private static String[] m_Strings; //Field offset: 0x0

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 44)]
			private static HTTP_REQUEST_HEADER_ID() { }

			[CalledBy(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpRequestHeader)}, ReturnType = typeof(void))]
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			internal static string ToString(int position) { }

		}

		private static String[] m_Strings; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 33)]
		private static HttpApi() { }

	}

	public static class SecureStringHelper
	{

		[CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FtpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SystemNetworkCredential), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SystemNetworkCredential), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkCredential), Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[Calls(Type = typeof(SecureString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SecureString), Member = ".ctor", ReturnType = typeof(void))]
		internal static SecureString CreateSecureString(string plainString) { }

		[CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest)}, ReturnType = typeof(PipelineEntry[]))]
		[CalledBy(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(NetworkCredential), Member = "InternalGetPassword", ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SecureString), Member = "get_Length", ReturnType = typeof(int))]
		[Calls(Type = typeof(Marshal), Member = "SecureStringToGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SecureString)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStringUni", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal static string CreateString(SecureString secureString) { }

	}


}

