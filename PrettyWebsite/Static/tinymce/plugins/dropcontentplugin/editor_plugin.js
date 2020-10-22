﻿(function (tinymce, DEBUG) {
    var eventNames = [
        "onPreInit", "onBeforeRenderUI", "onPostRender", "onLoad", "onInit", "onRemove", "onActivate", "onDeactivate",
        "onClick", "onEvent", "onMouseUp", "onMouseDown", "onDblClick", "onKeyDown", "onKeyUp", "onKeyPress",
        "onContextMenu", "onSubmit", "onReset", "onPaste", "onPreProcess", "onPostProcess", "onBeforeSetContent",
        "onBeforeGetContent", "onSetContent", "onGetContent", "onLoadContent", "onSaveContent", "onNodeChange",
        "onChange", "onBeforeExecCommand", "onExecCommand", "onUndo", "onRedo", "onVisualAid", "onSetProgressState",
        "onSetAttrib"
    ];
    
    tinymce.create("tinymce.plugins.dropcontentplugin",
        {
            initialized: false,
            init: function (ed) {
                var convertToDomElement = function (inputString) {
                    var tempParentElement = document.createElement("div");
                    tempParentElement.innerHTML = inputString;
                    return tempParentElement.firstChild;
                }

                ed.on("BeforeSetContent", function (editor) {
                    var node = convertToDomElement(editor.content);
                    if (node && node.nodeName === "A") { // Check if the content is a link
                        var hrefValue = node.getAttribute("href");
                        if (hrefValue === "#contact" || hrefValue === "#dynamiccontentblock" || hrefValue === "#loggainlankblock") { // Is the link our block ?
                            editor.content = node.innerText; // Only sets the value of link as content.
                        }
                    }
                });

                // ToDo: BeforeSetContent wrap all our block data {{ some data }} in a draggable tag
                // ToDo: Remove this draggable tag before save.

                if (DEBUG) {
                    var event,
                        eventNamesLength = eventNames.length;
                    for (var i = 0; i < eventNamesLength; i++) {
                        event = eventNames[i];
                        ed[event].add(function () {
                            console.log("editor_plugin:", arguments);
                        }.bind(this, event));
                    }
                }
            }
        });
    tinymce.PluginManager.add("dropcontentplugin", tinymce.plugins.dropcontentplugin);
})(tinymce, false);

