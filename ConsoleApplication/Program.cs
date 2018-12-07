namespace ConsoleApplication
{
    using System;

    using ExpressiveReturnTypes.Example.ValueTypes.Email;
    using ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    class Program
    {
        static void Main()
        {
            var userController = new UserController(
                new Username.Factory(s => s == "default"),
                new Password.Factory(),
                new EmailThatIsNotInUse.Factory(new Email.Factory(new [] { "google.com"}), new IsEmailInUse()));

            var result = userController.Post("", "", "asd@google.com");
        }
    }
}