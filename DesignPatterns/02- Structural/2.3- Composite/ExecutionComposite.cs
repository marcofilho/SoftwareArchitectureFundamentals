namespace DesignPatterns
{
    public class ExecutionComposite
    {
        public static void Execute()
        {
            var registerValidation = new Message("Registration was not completed!");

            var formUserError = new Message("The user entered an invalid name");

            var nameLengthError = new InputFormMessage("The name must have more than 2 characters");
            var emptyNameError = new InputFormMessage("The name cannot contain numbers");

            formUserError.AddDaughter(nameLengthError);
            formUserError.AddDaughter(emptyNameError);

            registerValidation.AddDaughter(formUserError);

            var domainUserError = new Message("Problems processing user registration");

            var userCpfDomain = new DomainMessage("The provided CPF is already in use!");
            var userEmailDomain = new DomainMessage("The provided email is already in use!");

            domainUserError.AddDaughter(userCpfDomain);
            domainUserError.AddDaughter(userEmailDomain);

            registerValidation.AddDaughter(domainUserError);

            var lvl1Msg = new Message("Level 1");
            var lvl2Msg = new Message("Level 2");
            var lvl3Msg = new Message("Level 3");
            var lvl4Msg = new Message("Level 4");
            var lvl5Msg = new Message("Level 5");

            lvl4Msg.AddDaughter(lvl5Msg);
            lvl3Msg.AddDaughter(lvl4Msg);
            lvl2Msg.AddDaughter(lvl3Msg);
            lvl1Msg.AddDaughter(lvl2Msg);

            registerValidation.AddDaughter(lvl1Msg);

            registerValidation.ShowMessages(2);
        }
    }
}