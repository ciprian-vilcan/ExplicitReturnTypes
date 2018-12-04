namespace ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse
{
    using ExpressiveReturnTypes.Example.Flows.CreateUser;

    public class IsEmailInUse : IMethod<IEmail, IMaybe>
    {
        /// <inheritdoc />
        public IMaybe Execute(IEmail parameters)
        {
            Maybe result = parameters.Value == "vasile@vasile.com";

            return result;
        }
    }
}
