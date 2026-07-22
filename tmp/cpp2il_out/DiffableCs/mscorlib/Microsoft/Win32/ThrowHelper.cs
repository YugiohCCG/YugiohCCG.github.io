namespace Microsoft.Win32;

internal static class ThrowHelper
{

	[CalledBy(Type = typeof(RegistryKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeRegistryHandle), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(RegistryView)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegistryKey), Member = "OpenBaseKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryHive), typeof(RegistryView)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "ValidateKeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegistryKey), Member = "ValidateKeyView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegistryView)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowArgumentException(string msg, string argument) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "ValidateKeyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowArgumentNullException(string argument) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "OpenSubKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalSubKeyCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetSubKeyNames", ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(RegistryKey), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(RegistryValueOptions)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "InternalGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RegistryKey), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegistryKey), Member = "EnsureNotDisposed", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowObjectDisposedException(string objectName, string msg) { }

	[CalledBy(Type = typeof(RegistryKey), Member = "InternalOpenSubKeyCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(RegistryKey))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void ThrowSecurityException(string msg) { }

}

