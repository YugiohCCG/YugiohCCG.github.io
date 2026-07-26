#target photoshop

(function () {
    var inputPath = $.getenv("CCG_HOLOGRAM_INPUT");
    var outputPath = $.getenv("CCG_HOLOGRAM_OUTPUT");
    var logPath = $.getenv("CCG_HOLOGRAM_LOG");
    var overwrite = $.getenv("CCG_HOLOGRAM_OVERWRITE") === "1";

    if (!inputPath || !outputPath || !logPath) {
        throw new Error(
            "CCG_HOLOGRAM_INPUT, CCG_HOLOGRAM_OUTPUT, and CCG_HOLOGRAM_LOG are required."
        );
    }

    var inputFolder = new Folder(inputPath);
    var outputFolder = new Folder(outputPath);
    if (!inputFolder.exists) {
        throw new Error("Input folder does not exist: " + inputPath);
    }
    if (!outputFolder.exists && !outputFolder.create()) {
        throw new Error("Could not create output folder: " + outputPath);
    }

    var logFile = new File(logPath);
    if (!logFile.open("w")) {
        throw new Error("Could not open log file: " + logPath);
    }
    logFile.encoding = "UTF-8";
    logFile.lineFeed = "Windows";
    logFile.writeln("file\tstatus\tdetail");

    var files = inputFolder.getFiles(function (entry) {
        return entry instanceof File && /\.(jpe?g|png)$/i.test(entry.name);
    });
    files.sort(function (a, b) {
        return a.name.toLowerCase() < b.name.toLowerCase() ? -1 : 1;
    });

    var previousDialogs = app.displayDialogs;
    var previousRulerUnits = app.preferences.rulerUnits;
    app.displayDialogs = DialogModes.NO;
    app.preferences.rulerUnits = Units.PIXELS;

    var processed = 0;
    var skipped = 0;
    var failed = 0;

    function selectSubject() {
        var descriptor = new ActionDescriptor();
        descriptor.putBoolean(stringIDToTypeID("sampleAllLayers"), false);
        executeAction(stringIDToTypeID("autoCutout"), descriptor, DialogModes.NO);
    }

    function revealSelectionAsMask() {
        var descriptor = new ActionDescriptor();
        descriptor.putClass(charIDToTypeID("Nw  "), charIDToTypeID("Chnl"));
        var destination = new ActionReference();
        destination.putEnumerated(
            charIDToTypeID("Chnl"),
            charIDToTypeID("Chnl"),
            charIDToTypeID("Msk ")
        );
        descriptor.putReference(charIDToTypeID("At  "), destination);
        descriptor.putEnumerated(
            charIDToTypeID("Usng"),
            charIDToTypeID("UsrM"),
            charIDToTypeID("RvlS")
        );
        executeAction(charIDToTypeID("Mk  "), descriptor, DialogModes.NO);
    }

    try {
        for (var index = 0; index < files.length; index++) {
            var source = files[index];
            var baseName = source.name.replace(/\.[^.]+$/, "");
            var destination = new File(outputFolder.fsName + "/" + baseName + ".png");
            if (destination.exists && !overwrite) {
                skipped++;
                logFile.writeln(source.name + "\tskipped\toutput exists");
                continue;
            }

            var document = null;
            try {
                document = app.open(source);
                if (document.mode !== DocumentMode.RGB) {
                    document.changeMode(ChangeMode.RGB);
                }
                if (document.bitsPerChannel !== BitsPerChannelType.EIGHT) {
                    document.bitsPerChannel = BitsPerChannelType.EIGHT;
                }

                document.activeLayer = document.layers[0];
                if (document.activeLayer.isBackgroundLayer) {
                    document.activeLayer.isBackgroundLayer = false;
                }

                selectSubject();
                revealSelectionAsMask();
                document.selection.deselect();
                document.resizeImage(
                    UnitValue(512, "px"),
                    UnitValue(512, "px"),
                    null,
                    ResampleMethod.BICUBICSHARPER
                );

                var options = new PNGSaveOptions();
                options.interlaced = false;
                document.saveAs(destination, options, true, Extension.LOWERCASE);
                processed++;
                logFile.writeln(source.name + "\tprocessed\t" + destination.name);
            } catch (error) {
                failed++;
                logFile.writeln(
                    source.name + "\tfailed\t" +
                    String(error).replace(/[\r\n\t]+/g, " ")
                );
            } finally {
                if (document !== null) {
                    document.close(SaveOptions.DONOTSAVECHANGES);
                }
            }
        }
    } finally {
        app.preferences.rulerUnits = previousRulerUnits;
        app.displayDialogs = previousDialogs;
        logFile.close();
    }

    return (
        "processed=" + processed +
        "; skipped=" + skipped +
        "; failed=" + failed +
        "; total=" + files.length
    );
}());
