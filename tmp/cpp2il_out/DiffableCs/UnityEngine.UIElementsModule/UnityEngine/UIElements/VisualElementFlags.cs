namespace UnityEngine.UIElements;

[Flags]
internal enum VisualElementFlags
{
	WorldTransformDirty = 1,
	WorldTransformInverseDirty = 2,
	WorldClipDirty = 4,
	BoundingBoxDirty = 8,
	WorldBoundingBoxDirty = 16,
	EventInterestParentCategoriesDirty = 32,
	LayoutManual = 64,
	CompositeRoot = 128,
	RequireMeasureFunction = 256,
	EnableViewDataPersistence = 512,
	DisableClipping = 1024,
	NeedsAttachToPanelEvent = 2048,
	HierarchyDisplayed = 4096,
	StyleInitialized = 8192,
	DisableRendering = 16384,
	Needs3DBounds = 32768,
	LocalBounds3DDirty = 65536,
	DetachedDataSource = 131072,
	ReceivesHierarchyGeometryChangedEvents = 262144,
	BoundingBoxDirtiedSinceLastLayoutPass = 524288,
	Init = 196671,
}

