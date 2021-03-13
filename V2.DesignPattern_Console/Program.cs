using System;
using V2.DesignPattern_Console.Mediator.Implementaion;
using V2.DesignPatterns.Memento;

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


            Console.WriteLine("Hello World!");
        }
    }
}
