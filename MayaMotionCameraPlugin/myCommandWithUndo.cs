//using System;
//using Autodesk.Maya.Runtime;
//using Autodesk.Maya.OpenMaya;

//// This line is mandatory to declare a new command in Maya
//// You need to change the last parameter without your own
//// node name and unique ID
//#warning You may need to change the Command name before continuing, then remove this line.
//[assembly: MPxCommandClass(typeof(MayaMotionCameraPlugin.MyCommandWithUndo), "MyCommandWithUndo")]

//namespace MayaMotionCameraPlugin
//{
//    // This class is instantiated by Maya each time when a command 
//    // is called by the user or a script.
//    public class MyCommandWithUndo : MPxCommand, IMPxCommand, IUndoMPxCommand
//    {

//        override public void doIt(MArgList argl)
//        {
//            // Put your command code here
//            // ...

//            redoIt();
//        }

//        override public void redoIt()
//        {
//            // Put your redo code here
//            // ...

//        }

//        override public void undoIt()
//        {
//            // Put your undo code here
//            // ...

//        }

//    }

//}

