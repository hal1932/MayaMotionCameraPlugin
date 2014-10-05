using System;
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
        private MObject _transform;
        private MObject _shape;

        private MDagModifier _dagModifier;


        public override void doIt(MArgList argl)
        {
            MGlobal.displayInfo("Hello World\n");

            _dagModifier = new MDagModifier();

            _transform = _dagModifier.createNode("camera");
            _dagModifier.renameNode(_transform, "motionCamera");

            redoIt();
        }

        override public void redoIt()
        {
            _dagModifier.doIt();

            var dagFn = new MFnDagNode(_transform);
            _shape = dagFn.child(0);
            _dagModifier.renameNode(_shape, "motionCameraShape");
            _dagModifier.doIt();
        }

        override public void undoIt()
        {
            _dagModifier.deleteNode(_transform);
            _dagModifier.deleteNode(_shape);
            _dagModifier.doIt();
        }

        public override bool isUndoable()
        {
            return true;
        }
    }

}
