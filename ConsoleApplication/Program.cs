namespace ConsoleApplication
{
    using System;

    using ExpressiveExceptions;

    using ExpressiveReturnTypes;
    using ExpressiveReturnTypes.Example.Flows.CreateUser;
    using ExpressiveReturnTypes.Example.ValueTypes.Email;
    using ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    class Program
    {
        static void Main()
        {
            var asd = new CreateUserService(
                new Username.Factory(s => s != "default"),
                new Password.Factory(),
                new EmailThatIsNotInUse.Factory(new Email.Factory(new [] { "google.com"}), new IsEmailInUse()));

            var result = asd
                .Execute(new CreateUserParams("default", "123", "q"))
                .Match(
                    user => user.ToString(), 
                    failures => failures.Aggregate(
                        (u, p, e) => u.AggregateWithBase(
                            p,
                            e,
                            (object o) => o.ToString(),
                            strings => string.Join(Environment.NewLine, strings))));
        }
    }
}