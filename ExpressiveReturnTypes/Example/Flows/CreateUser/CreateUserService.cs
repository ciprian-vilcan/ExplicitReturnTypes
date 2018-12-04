namespace ExpressiveReturnTypes.Example.Flows.CreateUser.FullyFunctional
{
    using ExpressiveReturnTypes.Example.ValueTypes.Email;
    using ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse;
    using ExpressiveReturnTypes.Example.ValueTypes.Password;
    using ExpressiveReturnTypes.Example.ValueTypes.Username;

    public class CreateUserService : IMethod<
        CreateUserParams,
        IEither<User, IAny<InvalidUsername, InvalidPassword, InvalidEmailThatIsNotInUse>>>
    {
        private readonly IMethod<InstantiateIUsernameParams, IEither<IUsername, InvalidUsername>> usernameFactory;

        private readonly IMethod<InstantiateIPasswordParams, IEither<IPassword, InvalidPassword>> passwordFactory;

        private readonly IMethod<InstantiateIEmailParams, IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>> emailFactory;

        public CreateUserService(
            IMethod<InstantiateIUsernameParams, IEither<IUsername, InvalidUsername>> usernameFactory,
            IMethod<InstantiateIPasswordParams, IEither<IPassword, InvalidPassword>> passwordFactory,
            IMethod<InstantiateIEmailParams, IEither<IEmailThatIsNotInUse, InvalidEmailThatIsNotInUse>> emailFactory)
        {
            this.usernameFactory = usernameFactory;
            this.passwordFactory = passwordFactory;
            this.emailFactory = emailFactory;
        }

        public IEither<User, IAny<InvalidUsername, InvalidPassword, InvalidEmailThatIsNotInUse>> Execute(CreateUserParams parameters)
        {
            var usernameResult = this.usernameFactory.Execute(parameters.Username);

            var passwordResult = this.passwordFactory.Execute(parameters.Password);

            var emailResult = this.emailFactory.Execute(parameters.Email);

            var result = usernameResult.MatchOnlyCase1(
                passwordResult,
                emailResult,
                (u, p, e) => new User(u, p, e));

            return result;
        }
    }
}