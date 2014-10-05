using System;
using Autodesk.Maya.Runtime;
using Autodesk.Maya.OpenMaya;

// This line is mandatory to declare a new command in Maya
// You need to change the last parameter without your own
// node name and unique ID
//#warning You need to change the Command name before continuing, then remove this line.
[assembly: MPxCommandClass(typeof(MayaMotionCameraPlugin.MotionCameraCommand), "motionCamera")]

namespace MayaMotionCameraPlugin
{
    // This class is instantiated by Maya each time when a command 
    // is called by the user or a script.
    public class MotionCameraCommand : MPxCommand, IMPxCommand, IUndoMPxCommand
    {
        private MObject _transformObj;
        private MObject _shapeObj;

        private MDagModifier _dagModifier;


        public override void doIt(MArgList argl)
        {
            MGlobal.displayInfo("Hello World\n");

            _dagModifier = new MDagModifier();

            _transformObj = _dagModifier.createNode("transform");
            _dagModifier.renameNode(_transformObj, "motionCameraTransform");

            _shapeObj = _dagModifier.createNode("camera");
            _dagModifier.renameNode(_shapeObj, "motionCamera");

            redoIt();
        }

        override public void redoIt()
        {
        }

        override public void undoIt()
        {
        }

        public override bool isUndoable()
        {
            return true;
        }
    }

}
