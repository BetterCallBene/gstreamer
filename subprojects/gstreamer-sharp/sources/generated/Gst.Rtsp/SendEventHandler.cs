// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Rtsp {

	using System;

	public delegate void SendEventHandler(object o, SendEventArgs args);

	public class SendEventArgs : GLib.SignalArgs {
		public IntPtr Object{
			get {
				return (IntPtr) Args [0];
			}
		}

		public IntPtr P0{
			get {
				return (IntPtr) Args [1];
			}
		}

	}
}