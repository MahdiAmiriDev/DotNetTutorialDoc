using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface ICommand
    {
        void Execute();

        void UnExecute();
    }

    class AddTextCommand : ICommand
    {
        private string _text;
        private TextEditor _textEditor;

        public AddTextCommand(TextEditor textEditor, string text)
        {
            _textEditor = textEditor;
            _text = text;
        }

        public void Execute()
        {
            _textEditor.AddText(_text);
        }

        public void UnExecute()
        {
            _textEditor.RemoveWord(_text);
        }
    }

    class RemoveTextCommand : ICommand
    {
        private string _text;
        private TextEditor _textEditor;

        public RemoveTextCommand(TextEditor textEditor, string text)
        {
            _textEditor = textEditor;
            _text = text;
        }

        public void Execute()
        {
            _textEditor.RemoveWord(_text);
        }

        public void UnExecute()
        {
            _textEditor.AddText(_text);
        }
    }

    class TextEditor
    {
        private string _text = string.Empty;

        public TextEditor()
        {

        }

        public void AddText(string text)
        {
            _text += text;
        }

        public void RemoveWord(string word)
        {
            var index = _text.LastIndexOf(word);

            _text = _text.Substring(0, index);
        }

        public void WriteText()
        {
            Console.WriteLine(_text);
        }
    }

    class CommandManager
    {
        private Stack<ICommand> _commands;

        public CommandManager()
        {
            _commands = new Stack<ICommand>();
        }

        public void Execute(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
        }

        public void Undo()
        {
            if (_commands.Any())
            {
                var command = _commands.Last();
                command.UnExecute();
                _commands.Pop();
            }
        }
    }
}
