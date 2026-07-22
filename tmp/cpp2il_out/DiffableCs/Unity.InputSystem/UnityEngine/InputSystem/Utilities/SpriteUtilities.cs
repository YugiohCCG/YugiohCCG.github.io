namespace UnityEngine.InputSystem.Utilities;

internal static class SpriteUtilities
{

	[CalledBy(Type = typeof(OnScreenStick), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DefaultFormat), typeof(TextureCreationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color32)}, ReturnType = typeof(Unity.Collections.NativeArray`1<UnityEngine.Color32>))]
	[Calls(Type = typeof(UnsafeUtility), Member = "MemSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(byte), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType)}, ReturnType = typeof(Sprite))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static Sprite CreateCircleSprite(int radius, Color32 colour) { }

}

