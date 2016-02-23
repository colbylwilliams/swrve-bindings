using System;
using Android.Runtime;

namespace Com.Swrve.Sdk
{
	public abstract partial class SwrveBase
	{
		static Delegate cb_getAssetsOnDisk;
#pragma warning disable 0169
		static Delegate GetGetAssetsOnDiskHandler ()
		{
			if (cb_getAssetsOnDisk == null)
				cb_getAssetsOnDisk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>)n_GetAssetsOnDisk);
			return cb_getAssetsOnDisk;
		}

		static IntPtr n_GetAssetsOnDisk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Swrve.Sdk.SwrveBase __this = global::Java.Lang.Object.GetObject<global::Com.Swrve.Sdk.SwrveBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.AssetsOnDisk);
		}
#pragma warning restore 0169

		static IntPtr id_getAssetsOnDisk;
		public override unsafe global::System.Collections.Generic.ICollection<string> AssetsOnDisk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.swrve.sdk']/class[@name='SwrveBase']/method[@name='getAssetsOnDisk' and count(parameter)=0]"
			[Register ("getAssetsOnDisk", "()Ljava/util/Set;", "GetGetAssetsOnDiskHandler")]
			get {
				if (id_getAssetsOnDisk == IntPtr.Zero)
					id_getAssetsOnDisk = JNIEnv.GetMethodID (class_ref, "getAssetsOnDisk", "()Ljava/util/Set;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAssetsOnDisk), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAssetsOnDisk", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}
	}
}

namespace Com.Swrve.Sdk.Conversations.UI
{
	public partial class ConversationActivity
	{
		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>)n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Swrve.Sdk.Conversations.UI.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Swrve.Sdk.Conversations.UI.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.swrve.sdk.conversations.ui']/class[@name='ConversationActivity']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		protected override unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			if (id_onCreate_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreate_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (Handle, id_onCreate_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}
	}
}