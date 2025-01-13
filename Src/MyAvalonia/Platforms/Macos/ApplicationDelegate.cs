namespace MyAvalonia.Platforms.Macos;

public class ApplicationDelegate : NSApplicationDelegate
{
   public override NSMenu ApplicationDockMenu(NSApplication sender)
   {
      return base.ApplicationDockMenu(sender);
   }

   public override bool OpenFile(NSApplication sender, string filename)
   {
      return false;
   }

   public override void WillFinishLaunching(NSNotification notification)
   {
      base.WillFinishLaunching(notification);
   }
}