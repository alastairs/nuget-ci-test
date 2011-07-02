using System;
using System.Reactive.Linq;
using System.Threading;

namespace CITest
{
    public class Class1
    {
        // The point of this code is to exercise the build system. This is why it's rubbish.  
        public void DoStuff()
        {
            // This sample cam from http://rxwiki.wikidot.com/101samples#toc1
            // Observable comes from the Reactive Extensions, which is included via NuGet. If NuGet build steps fail, the project will not build.
            var o = Observable.Start(() =>
                                         {
                                             Console.WriteLine("Calculating..."); 
                                             Thread.Sleep(3000); 
                                             Console.WriteLine("Done.");
                                         });

            o.First();
        }

        // NOTE: Confirmed build on my machine.
    }
}
