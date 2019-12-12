using System;

namespace DependencyInjection
{
    //https://www.codementor.io/mrfojo/c-with-dependency-injection-k2qfxbb8q
    //Loosly Coupling for DI Create Interface
    public interface IEmailService
    {
        void SendMail(string emailAddress, string message);
    }

    public class UserLogic
    {
        private GoogleOAuthService _authService;
        private IEmailService _emailService;

        public UserLogic(IEmailService emailService)
        {
            _authService = new GoogleOAuthService();
            _emailService = emailService;
        }

        public void Register(string emailAddress, string password)
        {
            _authService.RegisterUser(emailAddress, password);
            _emailService.SendMail(emailAddress, "authResult.ConfirmationMessage");
        }
    }

    public class GoogleOAuthService
    {
        public void RegisterUser(string emailAddress, string password)
        {
            Console.WriteLine("//Register a new user");
        }
    }

    public class GoogleEmailService: IEmailService
    {

        public void SendMail(string emailAddress, string message)
        {
            Console.WriteLine("//Send an email using GOOGLE");
        }
    }
    //This New Implememtation will require lot of changes in code make loose by addin interface IEmailService
    public class OutlookEmailService: IEmailService
    {

        public void SendMail(string emailAddress, string message)
        {
            Console.WriteLine("//Send an email using OUTLOOK");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Here Injecting 
            UserLogic ul = new UserLogic( new OutlookEmailService());
            ul.Register("ANil", "pasword");
            Console.WriteLine("Hello World!");
        }
    }
}
