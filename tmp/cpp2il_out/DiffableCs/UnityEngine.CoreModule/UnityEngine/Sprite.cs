namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
public sealed class Sprite : object
{

	public Texture2D associatedAlphaSplitTexture
	{
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetAlphaTexture")]
		 get { } //Length: 144
	}

	public Vector4 border
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_hasBorder", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
	}

	public Bounds bounds
	{
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 148
	}

	public bool packed
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 124
	}

	public SpritePackingMode packingMode
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 118
	}

	public SpritePackingRotation packingRotation
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 118
	}

	public Vector2 pivot
	{
		[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetPivotInPixels")]
		 get { } //Length: 135
	}

	public float pixelsPerUnit
	{
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Sprite)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment", typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "Spine.Attachment")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "Spine.AtlasPage", typeof(float)}, ReturnType = "Spine.RegionAttachment")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(float)}, ReturnType = "Spine.RegionAttachment")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool), typeof(float)}, ReturnType = "Spine.RegionAttachment")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetPixelsToUnits")]
		 get { } //Length: 118
	}

	public Rect rect
	{
		[CalledBy(Type = "Scenes.General.Hologram", Member = "SetScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.DefaultElementBuilder", Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Card.Template", Member = "SetCardArtAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Battle.ArtDisplay+<ProcessEvent>d__28", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.General.Hologram", Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
	}

	public Texture2D texture
	{
		[CallerCount(Count = 46)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
	}

	public Rect textureRect
	{
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 160
	}

	public UInt16[] triangles
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public Vector2[] uv
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public Vector2[] vertices
	{
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeGeomRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private Sprite() { }

	[CalledBy(Type = "Scenes.Lobby.GameRoom", Member = "SetAvatar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.Janken+<DefinePlayer>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "UpdateUserInfo", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Lobby.LobbyScreen", Member = "DefineAvatarSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Customization", Member = "GetCustomImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(string), typeof(bool), typeof(bool), typeof(Sprite&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.ImageHandler", Member = "CreateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = "Manager.P2PManager+<OnNetworkPacket>d__57", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "DefineTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Image", typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.RoomCard", Member = "<PostSetData>b__37_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.UI.DebugUIHandlerToggleHistory", Member = "SetWidget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.DebugUI+Widget"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.AtlasRegion", typeof(float)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.SpriteUtilities", Member = "CreateCircleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Color32)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 40)]
	[ContainsUnimplementedInstructions]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr CreateSprite_Injected(IntPtr texture, in Rect rect, in Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, in Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetAlphaTexture")]
	public Texture2D get_associatedAlphaSplitTexture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_hasBorder", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector4 get_border() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Bounds get_bounds() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_packed() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SpritePackingMode get_packingMode() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SpritePackingRotation get_packingRotation() { }

	[CalledBy(Type = "Scenes.General.LifePoints+<MakeLPBar>d__23", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetPivotInPixels")]
	public Vector2 get_pivot() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Sprite)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentCloneExtensions", Member = "GetRemappedClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Attachment", typeof(Sprite), typeof(Material), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = "Spine.Attachment")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "Spine.AtlasPage", typeof(float)}, ReturnType = "Spine.RegionAttachment")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Shader), typeof(TextureFormat), typeof(bool), typeof(Material), typeof(float)}, ReturnType = "Spine.RegionAttachment")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AttachmentRegionExtensions", Member = "ToRegionAttachmentPMAClone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Material), typeof(TextureFormat), typeof(bool), typeof(float)}, ReturnType = "Spine.RegionAttachment")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetPixelsToUnits")]
	public float get_pixelsPerUnit() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Scenes.General.Hologram", Member = "SetScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.Hologram", Member = "SetHologram", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.ArtDisplay+<ProcessEvent>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "SetCardArtAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.DefaultElementBuilder", Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_rect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[CallerCount(Count = 46)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public Texture2D get_texture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToAtlasRegion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(bool)}, ReturnType = "Spine.AtlasRegion")]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_textureRect() { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	public UInt16[] get_triangles() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static UInt16[] get_triangles_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "ToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(TextureFormat), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	public Vector2[] get_uv() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeGeomRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	public Vector2[] get_vertices() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Vector4 GetInnerUVs() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[CalledBy(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Vector4 GetOuterUVs() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal int GetPacked() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetPacked_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal int GetPackingMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetPackingMode_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal int GetPackingRotation() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetPackingRotation_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Vector4 GetPadding() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal Rect GetTextureRect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetTextureRect_Injected(IntPtr _unity_self, out Rect ret) { }

}

