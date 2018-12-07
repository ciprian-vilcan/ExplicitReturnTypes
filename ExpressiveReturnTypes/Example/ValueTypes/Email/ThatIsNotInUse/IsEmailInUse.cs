namespace ExpressiveReturnTypes.Example.ValueTypes.Email.ThatIsNotInUse
{
    public class IsEmailInUse : IMethod<IEmail, bool>
    {
        /// <inheritdoc />
        public bool Execute(IEmail parameters)
        {
            var result = parameters.Value == "vasile@vasile.com";

            return result;
        }
    }
}
