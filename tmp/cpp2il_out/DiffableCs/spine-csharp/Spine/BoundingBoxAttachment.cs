namespace Spine;

public class BoundingBoxAttachment : VertexAttachment
{

	[CalledBy(Type = "Spine.Unity.RegionlessAttachmentLoader", Member = "NewBoundingBoxAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Skin), typeof(string)}, ReturnType = typeof(BoundingBoxAttachment))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public BoundingBoxAttachment(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexAttachment), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexAttachment), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttachment)}, ReturnType = typeof(void))]
	public virtual Attachment Copy() { }

}

