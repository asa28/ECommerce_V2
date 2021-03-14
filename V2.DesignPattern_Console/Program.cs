using System;
using V2.DesignPattern_Console.Mediator.Implementaion;
using V2.DesignPattern_Console.Strategy;
using V2.DesignPattern_Console.Strategy.Implementaion;
using V2.DesignPatterns.Memento;
using V2.DesignPattern_Console.Singletonn;

namespace V2.DesignPattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Memento
            //var editor = new Editor();
            //var history = new History();

            //editor.setContent("a");
            //history.push(editor.createState());


            //editor.setContent("b");
            //history.push(editor.createState());


            //editor.setContent("c");
            //history.push(editor.createState());

            //editor.setContent("d");
            //history.push(editor.createState());


            //editor.restore(history.pop());
            //// output : d

            //editor.restore(history.pop());
            //// output : c

            //Console.WriteLine(editor.getContent());
            #endregion

            #region Mediator

            //var dialog = new ArticalDialougBox();
            //dialog.SimulateUserInteraction();

            #endregion

            #region Startegy


            //var image = new ImageStorage();
            //image.store(FileName: "FileName_Ahmed", new JPEG_Compressor(), new B_W_Filter());
            //image.store(FileName: "FileName_Ahmed", new PNG_Compressor(), new High_Contrast_Filter());


            #endregion

            #region Singleton

            // error can't make new Singleton()
            //var _singleton = new Singleton();
            // only access is to get static one 
            //var _singleton = Singleton.get_Instance();

            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
