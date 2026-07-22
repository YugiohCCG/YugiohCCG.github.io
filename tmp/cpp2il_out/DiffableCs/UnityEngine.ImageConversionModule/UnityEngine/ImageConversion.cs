namespace UnityEngine;

[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion
{

	[CalledBy(Type = typeof(ImageConversion), Member = "EncodeToJPG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = True, ThrowsException = True)]
	public static Byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[CalledBy(Type = "Data.Player+<UpdateMyPlaymat>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.Player+<UpdateMySleeve>d__60", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToJPG", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Extension]
	public static Byte[] EncodeToJPG(Texture2D tex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void EncodeToJPG_Injected(IntPtr tex, int quality, out BlittableArrayWrapper ret) { }

	[CalledBy(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	public static bool LoadImage(Texture2D tex, ReadOnlySpan<Byte> data, bool markNonReadable) { }

	[CalledBy(Type = "Manager.ImageHandler", Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]"}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool)}, ReturnType = typeof(bool))]
	[Extension]
	public static bool LoadImage(Texture2D tex, Byte[] data, bool markNonReadable) { }

	[CalledBy(Type = "Manager.Customization+<GetCustomCursor>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization", Member = "CreateTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(bool), typeof(bool), typeof(Texture2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(System.ReadOnlySpan`1<System.Byte>), typeof(bool)}, ReturnType = typeof(bool))]
	[Extension]
	public static bool LoadImage(Texture2D tex, Byte[] data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool LoadImage_Injected(IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable) { }

}

