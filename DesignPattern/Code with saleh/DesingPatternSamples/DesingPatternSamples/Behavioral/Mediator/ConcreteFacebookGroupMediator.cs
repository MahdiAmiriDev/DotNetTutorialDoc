namespace DesingPatternSamples.Behavioral.Mediator
{
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {

        private List<User> _UserList = new List<User>();

        public void RegisterUser(User user)
        {
            _UserList.Add(user);

            user.Mediator = this;
        }

        public void SendMessage(string message, User user)
        {
            foreach (User u in _UserList)
            {
                //Message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }

}
