namespace ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using ExpressiveReturnTypes;
    using ExpressiveReturnTypes.Example.Flows.CreateUser;
    using ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public class UserController : ApiController
    {
        private readonly IMethod<string, IEither<IUsername, InvalidUsername>> usernameFactory;

        private readonly IMethod<string, IEither<IPassword, InvalidPassword>> passwordFactory;

        private readonly IMethod<string, IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>> emailFactory;

        public UserController(
            IMethod<string, IEither<IUsername, InvalidUsername>> usernameFactory,
            IMethod<string, IEither<IPassword, InvalidPassword>> passwordFactory,
            IMethod<string, IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>> emailFactory)
        {
            this.usernameFactory = usernameFactory;
            this.passwordFactory = passwordFactory;
            this.emailFactory = emailFactory;
        }

        public IHttpActionResult Post(string username, string password, string email)
        {
            IHttpActionResult result;

            var usernameResult = this.usernameFactory.Execute(username);
            var passwordResult = this.passwordFactory.Execute(password);
            var emailResult = this.emailFactory.Execute(email);

            if (usernameResult.IsCase1(out var validUsername) && passwordResult.IsCase1(out var validPassword)
                && emailResult.IsCase1(out var validEmail))
            {
                var user = new User(validUsername, validPassword, validEmail);
                result = this.Ok(user);
            }
            else
            {
                var errorResult = new IEither<object, ExpectedException>[] { usernameResult, passwordResult, emailResult }
                    .Select(p => p.IsCase2().Match(e => e.Message, string.Empty))
                    .Where(message => message != string.Empty)
                    .Aggregate((a, b) => a + Environment.NewLine + b);
                result = this.BadRequest(errorResult);
            }

            return result;
        }
    }
}
