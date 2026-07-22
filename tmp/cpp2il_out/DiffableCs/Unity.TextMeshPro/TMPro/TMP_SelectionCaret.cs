namespace TMPro;

[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SelectionCaret : MaskableGraphic
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TMP_SelectionCaret() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForGraphicRebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICanvasElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void Cull(Rect clipRect, bool validRect) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected virtual void UpdateGeometry() { }

}

