using Project_A;

namespace Project_B
{
    class ClassesTest
    {
        public ClassesTest()
        {
            var publicTest = new Public();
            //var privateTest = new Private();
            //var internalTest = new Internal();
            //var abstractTest = new Abstract();
        }
    }

    class ModifierTest1
    {
        public ModifierTest1()
        {
            var publicTest = new Public();

            publicTest.PublicTest();
            //publicTest.TesteInternal();
            //publicTest.ProtectedInternTest();
            //publicTest.ProtectedTest();
            //publicTest.PrivateProtectedTest();
            //publicTest.PrivateTest();
        }
    }

    class ModifierTest2 : Public
    {
        public ModifierTest2()
        {
            PublicTest();
            ProtectedTest();
            ProtectedInternTest();
            //InternalTest();
            //PrivateProtectedTest();
            //PrivateTest();
        }
    }
}
