//[assembly: InternalsVisibleTo("Project_B")]
namespace Project_A
{
    #region Classes

    public class Public
    {
        public void PublicTest() { }
        private void PrivateTest() { }
        internal void InternalTest() { }
        protected void ProtectedTest() { }
        private protected void PrivateProtectedTest() { }
        protected internal void ProtectedInternTest() { }
    }

    public sealed class Sealed { }

    class Private { }

    internal class Internal { }

    abstract class Abstract { }

    #endregion

    #region Tests

    class TestClasses
    {
        public TestClasses()
        {
            var publicClass = new Public();
            var privateClass = new Private();
            var internalClass = new Internal();
            //var abastractClass = new Abstract();
        }
    }

    //class SealedTest : Sealed { }

    class ModifierTest1
    {
        public ModifierTest1()
        {
            var publicTest = new Public();

            publicTest.PublicTest();
            publicTest.InternalTest();
            publicTest.ProtectedInternTest();
            //publicTest.ProtectedTest();
            //publicTest.PrivateProtectedTest();
            //publicTest.PriovateTest();
        }
    }

    class ModifierTest2 : Public
    {
        public ModifierTest2()
        {
            PublicTest();
            InternalTest();
            ProtectedTest();
            ProtectedInternTest();
            PrivateProtectedTest();
            //PrivateTest();
        }
    }

    #endregion
}

/*******************************************************/
// public:

// Access is not restricted.
/*******************************************************/
// protected:

// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:

// Access is limited to the current assembly.
/*******************************************************/
// protected internal:

// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:

// Access is limited to the containing type.
/*******************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/
