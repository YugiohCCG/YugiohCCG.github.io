namespace SimpleFileBrowser;

[RequireComponent(typeof(CanvasRenderer))]
public class NonDrawingGraphic : Graphic
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = ".ctor", ReturnType = typeof(void))]
	public NonDrawingGraphic() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetMaterialDirty() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public virtual void SetVerticesDirty() { }

}

