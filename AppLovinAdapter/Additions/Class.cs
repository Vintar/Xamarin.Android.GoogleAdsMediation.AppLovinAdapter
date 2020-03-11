using System;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Ads.Mediation.Applovin
{
	public partial class AppLovinMediationAdapter
    {
		public override unsafe void Initialize(global::Android.Content.Context context, global::Android.Gms.Ads.Mediation.IInitializationCompleteCallback initializationCompleteCallback, global::System.Collections.Generic.IList<global::Android.Gms.Ads.Mediation.MediationConfiguration> mediationConfigurations)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/google/android/gms/ads/mediation/InitializationCompleteCallback;Ljava/util/List;)V";
			IntPtr native_mediationConfigurations = global::Android.Runtime.JavaList<global::Android.Gms.Ads.Mediation.MediationConfiguration>.ToLocalJniHandle(mediationConfigurations);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
				__args[1] = new JniArgumentValue((initializationCompleteCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object)initializationCompleteCallback).Handle);
				__args[2] = new JniArgumentValue(native_mediationConfigurations);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_mediationConfigurations);
			}
		}
	}
}