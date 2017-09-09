using System;
using System.Runtime.InteropServices;

namespace FasettoChatApp.Core
{
    internal class StructureLayoutAttribute : Attribute
    {
        private LayoutKind sequential;

        public StructureLayoutAttribute(LayoutKind sequential)
        {
            this.sequential = sequential;
        }
    }
}