// See https://aka.ms/new-console-template for more information
using CrossPlatformConsoleApplication;

Console.WriteLine("Hello, World!");
HelloWorld helloWorld = new HelloWorld();
helloWorld.callHelloInPrivate();
helloWorld.HelloFromPublic();
Console.WriteLine( helloWorld.sum(3,5));
