using Syncfusion.XForms.iOS.TabView;
using Foundation;
using UIKit;

namespace KickassUI.ParallaxCarousel.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjAwOTY5QDMxMzcyZTM0MmUzMGI1ZDBXSEdtNlFBaThYcThSV096UklFTUUraHd4b2UwOWlKNjVlVVBIc2c9;MjAwOTcwQDMxMzcyZTM0MmUzMFlSOTNGcm9NdVkxVkFZcEZTMExsYTYxcFowd21Cd0pHUnlZNVJkQ3kwT1E9;MjAwOTcxQDMxMzcyZTM0MmUzMEltd29Ba01PaVBJWjd0M2lNblJVd1dpS3ArTUQxWlhNT2d2dUpRSWdIL2M9;MjAwOTcyQDMxMzcyZTM0MmUzMEZmUllVQUlsYUpSVjgzdkxjYnpNd0U2dEJ0NnI1VkVWYjkweWF2ZnVnOW89;MjAwOTczQDMxMzcyZTM0MmUzMEYzaDhUZmx1VXR2YjkrLzJqaGFMNmZkUE15RTNDL3N6d3RaK3dOaDJmS289;MjAwOTc0QDMxMzcyZTM0MmUzMGdQbXpFUHFDNW0veTB4S1pOeUNCTnE2WDExUWdjcGJvVXR1VitTUW1WRXM9;MjAwOTc1QDMxMzcyZTM0MmUzMGtKQldFR3BpTENUSzlnbFJXMVRaazkxOVR6QmJrKytPS1drcGphNnluM1E9;MjAwOTc2QDMxMzcyZTM0MmUzMEFhTW5zcDJkeU5oalFGaWMwY0hWK0c5MlV3dXQwck15Y0tuMzRnSE85cGs9;MjAwOTc3QDMxMzcyZTM0MmUzMElXWVhCNmJxOVJjaXlMR3JkS2ZGaXJnVFk5OTFFY3JGU2M5ZUpJWE02aVE9;NT8mJyc2IWhiZH1nfWN9YGpoYmF8YGJ8ampqanNiYmlmamlmanMDHmg5PCA7JjITJzw9Nyd9MDw+;MjAwOTc4QDMxMzcyZTM0MmUzMFpORUlEQnJnMFJVUnkvMzlWK3YwenRuMElrRWdpYXZRVFNRMmRnT2RabjQ9");

            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            global::Xamarin.Forms.Forms.Init();
            SfTabViewRenderer.Init();
            LoadApplication(new App());

            UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.Default, false);

            return base.FinishedLaunching(app, options);
        }
    }
}
