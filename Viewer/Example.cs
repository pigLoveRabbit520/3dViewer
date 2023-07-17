﻿/**
 * This WinForms project  and Example templates were created by referring to Three.cs( (https://github.com/lathoub/three.cs).  
 * */
using OpenTK;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using THREE;

namespace THREEExample
{
    abstract public class Example
    {
        public GLRenderer renderer;

        protected readonly Random random = new Random();


        protected readonly Stopwatch stopWatch = new Stopwatch();

        public GLControl glControl;
        public virtual void Load(GLControl control)
        {
            Debug.Assert(null != control);

            glControl = control;
            this.renderer = new THREE.GLRenderer();

            this.renderer.Context = control.Context;
            this.renderer.Width = control.Width;
            this.renderer.Height = control.Height;

            this.renderer.Init();

            stopWatch.Start();
        }

        public virtual void Resize(Size clientSize)
        {
            if (renderer != null)
                renderer.Resize(clientSize.Width, clientSize.Height);
        }

        public virtual void MouseUp(Size clientSize, Point point)
        {

        }

        public virtual void MouseWheel(Size clientSize, Point point, int delta)
        {

        }

        public virtual void MouseMove(Size clientSize, Point point)
        {

        }

        public virtual void MouseDown(Size clientSize, Point point)
        {

        }

        public abstract void Render();

        public virtual void Unload()
        {
            this.renderer.Dispose();
        }

        public virtual void KeyDown(OpenTK.Windowing.GraphicsLibraryFramework.Keys keyCode)
        {
            
        }
        public virtual void KeyUp(OpenTK.Windowing.GraphicsLibraryFramework.Keys keyCode)
        {

        }
    }
}
