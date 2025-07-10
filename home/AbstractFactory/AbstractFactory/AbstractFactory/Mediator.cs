using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //mediator
    interface IChatRoomMediator
    {
        void SendMessage(BaseChatRoomUser user, string message);

        void RegisterUser(BaseChatRoomUser user);
    }


    //colleague

    abstract class BaseChatRoomUser
    {
        public string UserName { get; set; }

        public IChatRoomMediator _mediator;

        protected BaseChatRoomUser(string userName)
        {
            UserName = userName;
        }

        public void SetChatRoom(IChatRoomMediator room)
        {
            _mediator = room;
        }

        public abstract void SendMessage(string message);
        public abstract void RecieveMessage(string message, string senderName);
    }


    //concerete colleague
    class ChatRoomUser : BaseChatRoomUser
    {
        public ChatRoomUser(string userName) : base(userName)
        {
        }

        public override void RecieveMessage(string message, string senderName)
        {
            Console.WriteLine("recevier is {0} and the message is: {1}", senderName, message);
        }

        public override void SendMessage(string message)
        {
            _mediator.SendMessage(this, message);
        }
    }

    //concrete mediator
    class ChatRoom : IChatRoomMediator
    {

        List<BaseChatRoomUser> _users = new();

        public void RegisterUser(BaseChatRoomUser user)
        {
            _users.Add(user);
            user.SetChatRoom(this);
        }

        public void SendMessage(BaseChatRoomUser user, string message)
        {
            foreach (var item in _users)
            {
                if (item.UserName != user.UserName)
                    item.RecieveMessage(message, item.UserName);
            }
        }
    }

}
